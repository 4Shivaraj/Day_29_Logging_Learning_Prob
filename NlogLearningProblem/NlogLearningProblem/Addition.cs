using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogLearningProblem
{
    public class Addition
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void sum(int first, int second)
        {
            if (first > 0 && second > 0)
            {
                int res = first + second;
                logger.Debug("Debug Succesfull with sum operation");
                logger.Info("Succesfully completed and Sum is" + res);

            }
            else
            {
                logger.Warn("Input Should Not Be 0 Or Less Than Zero");
                logger.Error("Input Should Be Positive Number");
            }
        }
    }
}
