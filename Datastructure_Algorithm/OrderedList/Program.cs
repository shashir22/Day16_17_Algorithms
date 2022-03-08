using System;

namespace OrderedList
{
	class Program
	{
		static void Main(string[] args)
		{
			OrderList<int> list = new OrderList<int>();
			list.insert(1);
			list.insert(2);
			list.insert(3);
			list.insertAtStart(0);
			list.insertAtEnd(2, 2);
			list.show();
			if (list.search(4))
			{
				Console.WriteLine("found");
			}
			else
			{
				Console.WriteLine("not found");
			}
			list.deleteAtEnd(2);
			list.deleteAtStart();
			list.show();
		}
	}
}