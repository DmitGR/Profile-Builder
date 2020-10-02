using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Operations : IComparable
	{
		DateTime dateTime;
		Double count;
		Operations op1, op2, op3, op4;
		UCstatus uCstatus;
		public Operations(DateTime dateTime, Operations op1, Operations op2, Operations op3, Operations op4, UCstatus uCstatus)
		{
			this.dateTime = dateTime;
			this.Op1 = op1;
			this.Op2 = op2;
			this.Op3 = op3;
			this.Op4 = op4;
			this.count = op1.Count + op2.Count + op3.Count + op3.Count;
			this.uCstatus = uCstatus;
		}

		public Operations(DateTime dateTime, double count, UCstatus uCstatus)
		{
			this.DateTime = dateTime;
			this.Count = count;
			this.uCstatus = uCstatus;
		}

		public DateTime DateTime { get => dateTime; set => dateTime = value; }
		public double Count { get => count; set => count = value; }
		internal Operations Op1 { get => op1; set => op1 = value; }
		internal Operations Op2 { get => op2; set => op2 = value; }
		internal Operations Op3 { get => op3; set => op3 = value; }
		internal Operations Op4 { get => op4; set => op4 = value; }

		public int CompareTo(object obj)
		{
			Operations op = obj as Operations;
			if(op != null)
			{
				return Count.CompareTo(op.Count);
			}
			else
			throw new NotImplementedException();
		}
	}
}
