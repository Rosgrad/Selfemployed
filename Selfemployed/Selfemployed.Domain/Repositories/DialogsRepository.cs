using Selfemployed.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selfemployed.Domain.Repositories
{
   
        public interface IDialogsRepository
        {
            IReadOnlyCollection<RGDialogsClients> Get();
        }

        public class DialogsRepository : IDialogsRepository
        {
            private static readonly List<RGDialogsClients> _dialogsClients = new RGDialogsClients().Init();

            public IReadOnlyCollection<RGDialogsClients> Get()
            {
                return _dialogsClients;
            }
        }
   
}
