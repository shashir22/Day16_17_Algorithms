using System;
using System.Collections.Generic;
using System.Text;

namespace OrderedList
{
	public class Node<T>
	{
		public T data;
		public Node<T> next;

		public Node(T data2)
		{
			this.data = (T)data2; // the initialized data is set as the head
			this.next = null; // the next node is set to  null, as if there is no node
		}

		// method that return data of a given node
		public T getdata()
		{
			return data;
		}

		//method that gets the next node
		Node<T> getNext()
		{
			return next;
		}

		//sets data in node
		public void setData(T newData)
		{
			this.data = newData;
		}

		public void setNext(Node<T> newNext)
		{
			this.next = newNext;
		}

	}
}