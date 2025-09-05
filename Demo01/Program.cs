namespace Demo01
{
    //Blind 75
    //https://leetcode.com/problem-list/v9c2aln6/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //_20_ValidParentheses
            _20_ValidParentheses _20_ValidParentheses = new _20_ValidParentheses();
            Console.WriteLine(_20_ValidParentheses.IsValid("()"));
            Console.WriteLine(_20_ValidParentheses.IsValid("()[]{}"));
            Console.WriteLine(_20_ValidParentheses.IsValid("(]"));
            Console.WriteLine(_20_ValidParentheses.IsValid("([])"));
            Console.WriteLine(_20_ValidParentheses.IsValid("([)]"));


            Console.ReadLine();

        }






    }
}
