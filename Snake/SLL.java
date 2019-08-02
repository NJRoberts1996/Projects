
public class SLL<T>
{   
	private Element<T> head;  // list header
	private Element<T> tail;
	
    public SLL()
    {  head = null;  
	   tail = null;        
    }
    public boolean prepend(T newElement) //insert at head
    {  
		Element<T> temp = new Element<T>(newElement);
        if(temp == null) // out of memory
           return false;
        else
        {  
	       if (head==null)
		   {
			head = temp;
			tail = temp;
		   }
           else
           {
			 temp.next = head;
			 head = temp;
		   }
		}
        return true;
    }
	 public boolean append(T newElement) //insert at head
    {  
		Element<T> temp = new Element<T>(newElement);
        if(temp == null) // out of memory
           return false;
        else
        {  
	       if (head==null)
		   {
			head = temp;
			tail = temp;
		   }
           else
           {
			 tail.next = temp;
			 tail = temp;
		   }
		}
     return true;
    }
    
  
   public T getHead()
   {
	   
	   if (head == null)//item not found
		   return null;
	   else 
		   return head.data;
   }
   public T deleteHead()
   {
	   T deleted;
	   if (head == null)//item not found
		   return null;
	   else 
	   {
		   deleted = head.data;
		   head = head.next;
		   return deleted;
	   }
   }
   public T getTail()
   {
	   
	   if (head == null)//item not found
		   return null;
	   else 
		   return tail.data;
   }


	public String toString()
	{
		Element<T> ptr = head;
		String s="";
		while (ptr != null) //continue to traverse the list
		{   
			s+= ptr.data.toString( )+ " ";
			ptr = ptr.next;
		}
		return s;
	}
   
  public boolean isEmpty()
  {
	  if (head == null)
		  return true;
	  else 
		  return false;
  }
  
  public void showAll()
	{ 
		Element<T> ptr = head;
		while (ptr != null) //continue to traverse the list
		{   
			System.out.println(ptr.data);
            ptr = ptr.next;
		}
	}
  
  public class Element<T>
  {   
      private T data;
      private Element<T> next;
      public Element(T param)
     {
		 data = param;
     }
	  	
   }// end of inner class Node
}//end SinglyLinkedList outer class

