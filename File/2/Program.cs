namespace _2
{
    internal class Program
    {
        public bool AND(bool Firstbool, bool Secondbool)
        {
            if(Firstbool = true)
            {
                if(Secondbool = true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
    class PlusProgram : Program
    {
    }
    class PPProgram : PlusProgram
    {

    }
    class TPPProgram : PPProgram
    {

    }
    class SharpProgram : TPPProgram 
    { 

    }
}
