using System;

namespace ClassLibrary
{
    public class IdGenerator
    {
        private string departId;
        public string DepartId
        {
            get { return departId; }
            set
            {
                if (value.Length > 11 || value.Length < 11)
                {
                    throw new Exception("Идентификатор ведомства должен содержать 11 символов");
                }
                else
                {
                    departId = value;
                }
            }
        }

        public int ComplaintId { get; set; }

        public IdGenerator(string departId, int complaintId)
        {
            DepartId = departId;
            ComplaintId = complaintId;
        }

        public string CreateId(string departId, string complaintDate, int complaintId)
        {
            string id = String.Concat(departId, "_", complaintDate.ToString(), "_", complaintId.ToString());
            return id;
        }
    }
}
