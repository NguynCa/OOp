using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixProblem;

namespace FuntionsInheritance
{
    #region interface
    public interface ICalculate
    {
        Matrix multithreadCode(Matrix matrix1, Matrix matrix2);
        Matrix singlethreadCode(Matrix matrix1, Matrix matrix2);
    }
    public interface IPrepare
    {
        void initializeObject(ref Matrix A);
    }
    #endregion
    
}
