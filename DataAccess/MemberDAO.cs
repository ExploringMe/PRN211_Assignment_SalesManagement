using BusinessObject;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Data;

namespace DataAccess
{
    public class MemberDAO
    {
        FStoreContext FStoreDB;
        public MemberDAO()
        {
            FStoreDB = new FStoreContext();
        }

        public static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }

            }
        }


        public Member GetMemberByID(int MemberID)
        {
            Member member = null;
            return member;
        }

        public IEnumerable<Member> GetMembers()
        {
            var members = new List<Member>();
            foreach (var m in FStoreDB.Members)
            {
                members.Add(m);
            }
            return members;
        }

        public void AddMember(Member member)
        {

        }
        public void UpdateMember(Member member)
        {
            
        }
        public void DeleteMember(int memberID)
        {

        }
    }
}
