using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace DevSkillForum.BLL
{
    public class NinjectBLLModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ForumSection>().ToSelf();
        }
    }
}
