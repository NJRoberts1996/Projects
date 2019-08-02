
public class QueueAsSLL<T> extends SLL
{   
	private SLL<T> theQueue;  // list header
	
	
    public QueueAsSLL()
    {  theQueue = new SLL<T>();       
    }
	
    public boolean enqueue(T newElement) 
    {  
		   return theQueue.prepend(newElement);
    }
	
	public T dequeue() //remove from head
    {  
		T temp = null;
		temp = (T)theQueue.getHead();
		theQueue.deleteHead();
		return temp;
    }
	public String toString()
	{
		return theQueue.toString();
	}
	public boolean isEmpty()
	{
		return theQueue.isEmpty();
	}
   
}//end class

