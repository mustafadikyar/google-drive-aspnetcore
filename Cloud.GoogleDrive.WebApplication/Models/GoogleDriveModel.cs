using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cloud.GoogleDrive.WebApplication.Models
{
    public class GoogleDriveModel
    {
        public string Id { get; set; }
        public long? Size { get; set; }
        public string Name { get; set; }
        public long? Version { get; set; }
        public DateTime? CreatedTime { get; set; }
        public IList<string> Parents { get; set; }
        public string MimeType { get; set; }
    }
}