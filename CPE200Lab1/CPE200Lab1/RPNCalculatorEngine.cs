using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    public class RPNCalculatorEngine : CalculatorEngine
    {
        public override string Process(string str)
        {
            string _firstOp, _secondOp;
            string[] _parts = str.Split(' ');

            Stack<string> _nums = new Stack<string>();
            for (int i = 0; i < _parts.Length; i++)
            {
                if (isNumber(_parts[i]))
                {
                    _nums.Push(_parts[i]);
                }

                if (isOperator(_parts[i]))
                {
                    if (_nums.Count <= 1)
                    {
                        return "E";
                    }
                    else
                    {
                        _secondOp = _nums.Pop();
                        _firstOp = _nums.Pop();
                        _nums.Push(calculate(_parts[i], _firstOp, _secondOp));
                    }
                }
            }

            return (_nums.Count == 1) ? _nums.Pop() : "E";
        }
    }
}