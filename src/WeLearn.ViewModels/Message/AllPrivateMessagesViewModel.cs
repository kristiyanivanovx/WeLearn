using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeLearn.ViewModels.Message
{
    public class AllPrivateMessagesViewModel<T>
    {
        public List<T> PrivateMessageModels { get; set; }
    }
}
