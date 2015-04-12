using DevSkillForum.BLL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkillForum.DAL
{
    public class ForumSectionRepository : BaseRepository
    {
        public void Add(ForumSection section)
        {
            OpenConnection();

            DbCommand command = CreateCommand("Insert Into ForumSection Values(@ID, @Name, @DisplayOrder)");
            
            command.Parameters.Add(CreateParameter("@ID", section.ID));
            command.Parameters.Add(CreateParameter("@Name", section.Name));
            command.Parameters.Add(CreateParameter("@DisplayOrder", section.DisplayOrder));

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void Edit(ForumSection section)
        {

        }

        public void Delete(ForumSection section)
        {

        }
    }
}
