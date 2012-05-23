using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class VBus
    {
        protected VProvider provider;
        public virtual VProvider Provider
        {
            get { return provider; }
            set { provider = value; }
        }
        public  VBus()
        {
            provider = new VProvider();
        }
        public void BenginTran()
        {
            provider.BeginTransaction();
        }
        public void CommitTran()
        {
            provider.CommitTransaction();
        }
    }
}
