
using ActimizeETL.Core.Entities.Enums;

namespace ActimizeETL.Core.Entities
{
    public class ETLProcess: BaseEntity<string>
    {
        public ETLProcess()
        {
                Id = NUlid.Ulid.NewUlid().ToString();
        }
        public int Size { get; set; }
        public Sources Source { get; set; }
        public Destinations Destination { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; } 
        public ProcessStatus ProcessStatus { get; set; }
    }
}
