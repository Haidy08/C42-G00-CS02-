namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Commments
            // Single line Comment
            /**
             * Multi
             * line
             *Comment 
             */ 
            #endregion

            #region Varible Declaretions
            int Id = 10;
            //PascalCase = fristName
            //camelCase = fristName
            //Kabab-case = frist-name [Anglurs Files Naming ]
            //snake_case = frist_name
            Console.WriteLine(Id);
            #endregion

            #region ValueType
            int x;
            x = 3;
            int y = 4;
            y = x;
            Console.WriteLine(y);
            x++;
            Console.WriteLine(x); 
            #endregion
        }
    }
}
