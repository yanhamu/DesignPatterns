﻿namespace Interpreter
{
    public class ValueExpression : IExpression
    {
        private readonly int value;
        public ValueExpression(int value)
        {
            this.value = value;
        }

        public int Evaluate()
        {
            return value;
        }
    }
}
