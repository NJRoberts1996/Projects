import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
import java.util.*;

public class PlayWindow extends JFrame  implements KeyListener, ActionListener
{
	QueueAsSLL<SnakeElement> snake = new QueueAsSLL<SnakeElement>();
	int ROWS = 10;
	int COLS = 10;
	private final int TIME_DELAY = 800;
	int count = 0;
	int tel = 0;
	int key = 0;
	boolean goingUp = true;
	boolean goingDown = false;
	boolean goingLeft = false;
	boolean goingRight = false;
	
			
	private JLabel [][] screen = new JLabel[ROWS][COLS];
	private JLabel positionLabel;
	private JFrame frame;
	private JPanel basePanel, playAreaPanel, scorePanel;	
	
	private Snake mySnake;
  
	private SnakeElement snakeHead, snakeTail,current;
	private javax.swing.Timer timer;  
		
		
	PlayWindow()
	{
		super("Welcome to Snake");
		
		timer = new javax.swing.Timer(TIME_DELAY, new TimerListener());
        timer.start();
		
		//Create and set up the window
		frame = this;
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize (ROWS*40,COLS*40);
		
		// Create Panel for Score and other info		
		scorePanel = new JPanel();
		positionLabel = new JLabel("x:y");
		scorePanel.add(positionLabel);
		
		//create panel with playing grid
		playAreaPanel = new JPanel();
	    playAreaPanel.setSize (ROWS*50,COLS*50);
		GridLayout playLayout = new GridLayout(ROWS,COLS,0,0);
		playAreaPanel.setLayout(playLayout);
		playAreaPanel.addKeyListener(this);
		//create 2D Array of Lables
		for (int row = 0; row < ROWS; row ++)
			for (int col = 0; col< COLS; col ++)
			{
				screen[row][col] = new JLabel("X");
				playAreaPanel.add(screen[row][col]);
				screen[row][col].setVisible(false);
			}
		
		
		snakeHead = new SnakeElement(); // start in the center of the area
		mySnake = new Snake();
			
		snakeHead= (SnakeElement) mySnake.getFirst();
        screen[snakeHead.getRow()][snakeHead.getCol()].setVisible(true);		
		
		snakeTail = new SnakeElement();
		drawSnake();
		
		//Add panels to BasePanel
		basePanel =new JPanel();
		BorderLayout bLayout = new BorderLayout();
		basePanel.setLayout(bLayout);
		basePanel.add(scorePanel, BorderLayout.NORTH);
		basePanel.add(playAreaPanel, BorderLayout.CENTER);
		frame.add(basePanel);
		playAreaPanel.setFocusable(true);
		playAreaPanel.requestFocusInWindow();
		frame.setVisible(true);
		
	}
	public void paint(Graphics g) 
	{
        // Call the superclass paint method.
        super.paint(g);
        drawSnake();
        
    }
	public void drawSnake()
	{   // Cear screen - not really required
		for (int rw = 0; rw < ROWS; rw ++)
			for (int cl = 0; cl< COLS; cl ++)
			{
				screen[rw][cl].setVisible(false);
			}
		// draw snake
		current = new SnakeElement();
		for (int i = 0; i< mySnake.getSize();i++)
		{
			current= (SnakeElement) mySnake.getElement(i);
			System.out.printf("draw %d:%d,%d \n", i,current.getRow(),current.getCol());
			screen[current.getRow()][current.getCol()].setVisible(true);
		}
		
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
       	    playAreaPanel.requestFocusInWindow();
    }
	@Override
	public void keyPressed(KeyEvent e) 
	{
				
		key = e.getKeyCode();
		if (key == KeyEvent.VK_LEFT)
		{
			goingUp = goingDown =  goingRight = false;
			goingLeft = true;
		}
		if (key == KeyEvent.VK_UP)
		{
			goingLeft = goingDown =  goingRight = false;
			goingUp = true;
			
		}
		if (key == KeyEvent.VK_RIGHT)
		{
			goingLeft = goingDown =  goingUp = false;
			goingRight = true;
			
		}
		if (key == KeyEvent.VK_DOWN)
		{
			goingLeft = goingUp =  goingRight = false;
			goingDown = true;
		}
	}
	
	@Override
	public void keyReleased(KeyEvent e) { 
	
	}
	@Override
	public void keyTyped(KeyEvent e) {}
    
	private class TimerListener implements ActionListener {

        public void actionPerformed(ActionEvent e) {
            int headCol=0;
			int headRow=0;
			snakeTail = new SnakeElement();
			snakeTail = (SnakeElement) mySnake.getTail();
			screen[snakeTail.getRow()][snakeTail.getCol()].setVisible(false);
			
			snakeHead= new SnakeElement();
			snakeHead.deepCopy(mySnake.getFirst());
						
            if (goingUp) 
			{
				snakeHead.decrementRow();
			}
			if (goingDown)
			{
				snakeHead.incrementRow();
				
			}
			if (goingLeft)
			{
				snakeHead.decrementCol();
				
			}
			if (goingRight)
			{
				snakeHead.incrementCol();
			}
			positionLabel.setText(String.valueOf(snakeHead.getRow()) +":"+String.valueOf(snakeHead.getCol()));

			drawSnake();
			
		}
	}
	
	public class Snake
	{ 
	    int maxLength= (ROWS * COLS)-1;
		SnakeElement [] theSnake = new SnakeElement[maxLength];
		int snakeLength=0;
		
		public Snake()
		{
			snakeLength = 0;
		}
		public SnakeElement drawSnake(int row, int col, int size)
		{
			SnakeElement t = new SnakeElement(row, col);
			for (int i = (size-1); i >= 0; i--)
			{
				SnakeElement temp = new SnakeElement(row, (col -i)%COLS);
				snake.enqueue(temp);
				screen[temp.getRow()][temp.getCol()].setVisible(true);
			}
			snakeLength = size;
			snake.showAll();
			System.out.println();
			return t;
		}
		
		public void moveAhead(SnakeElement newHead)
		{
			if (snakeLength < maxLength && snakeLength > 0)
			{
				SnakeElement temp = snake.dequeue();
				screen[temp.getRow()][temp.getCol()].setVisible(false);
				snake.enqueue(newHead);
				screen[newHead.getRow()][newHead.getCol()].setVisible(true);
				snake.showAll();
				System.out.println();
			}
		}
		public SnakeElement getTail()
		{
			return theSnake[snakeLength-1];
		}
		
		public SnakeElement getFirst()
		{
			return theSnake[0];
		}
		
		public int getSize()
		{
			return snakeLength;
		}
		
		public SnakeElement getElement(int j)
		{
			if (j >=0 && j<maxLength)
				return theSnake[j];
			else
				return null;
		}
	}
		
	
	public class SnakeElement
	{
		int rowPos;
		int colPos;
		
		public SnakeElement()
		{
			this(0,0);
		}
		
		public SnakeElement(int r, int c)
		{
			if (r<ROWS)
				rowPos=r;
			else
				rowPos=0;
			if (c<COLS)
				colPos=c;
			else
				colPos=0;
		}
		
		void deepCopy(SnakeElement param)
		{
           rowPos=param.rowPos;
		   colPos=param.colPos;
		}
		
		void incrementRow()
		{
			if (rowPos < (ROWS-1))
			{
				rowPos++;
			}
			else
			{
				rowPos = 0;
			}
		}
		void decrementRow()
		{
			if (rowPos > 0)
			{
				rowPos--;
			}
			else
			{
				rowPos = ROWS-1;
			}
		}
		void incrementCol()
		{
			if (colPos < (COLS-1))
			{
				colPos++;
			}
			else
			{
				colPos = 0;
			}
		}
		void decrementCol()
		{
			if (colPos > 0)
			{
				colPos--;
			}
			else
			{
				colPos = COLS-1;
			}
		}
		int getRow ()
		{
			return rowPos;
		}
		int getCol ()
		{
			return colPos;
		}	
	}
	
	
 public static void main(String[] args) 
	{
		SwingUtilities.invokeLater(new Runnable() 
		{
			@Override
			public void run() {
				new PlayWindow().setVisible(true);
			}
		});
	}

}