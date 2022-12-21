namespace APIWithDapper.Entities
{
    public class ReportInfo
    {
        private long totalTransCount;

        private long cancelCount;

        private long usedCount;

        private string iD;

        private string traceCD;

        private string fileID;

        private string sarName;

        private string sarType;

        private string bizName;

        private string nationID;

        private decimal capital;

        private string cDate;

        private string regNo;

        private string regDT;

        private string regCity;

        private string licenseStatus;

        private string lastLicenseType;

        private string lastLicenseNo;

        private string lastLicenseDT;

        private string lastLicenseExpDT;

        private string wTel;

        private string mobile;

        private string ownType;

        private string stateCD;

        private string cityCD;

        private string addr;

        private string zipCD;

        private string lastLicenseTypeName;

        private string licenseSTName;

        public long TotalTransCount
        {
            get
            {
                return totalTransCount;
            }
            set
            {
                totalTransCount = value;
                if (totalTransCount < 0)
                {
                    totalTransCount = 0L;
                }
            }
        }

        public long CancelCount
        {
            get
            {
                return cancelCount;
            }
            set
            {
                cancelCount = value;
                if (cancelCount < 0)
                {
                    cancelCount = 0L;
                }
            }
        }

        public long UsedCount
        {
            get
            {
                return usedCount;
            }
            set
            {
                usedCount = value;
                if (usedCount < 0)
                {
                    usedCount = 0L;
                }
            }
        }

        public string ID
        {
            get
            {
                return iD;
            }
            set
            {
                iD = value;
            }
        }

        public string TraceCD
        {
            get
            {
                return traceCD;
            }
            set
            {
                traceCD = value;
            }
        }

        public string FileID
        {
            get
            {
                return fileID;
            }
            set
            {
                fileID = value;
            }
        }

        public string SarName
        {
            get
            {
                return sarName;
            }
            set
            {
                sarName = value;
            }
        }

        public string SarType
        {
            get
            {
                return sarType;
            }
            set
            {
                sarType = value;
            }
        }

        public string BizName
        {
            get
            {
                return bizName;
            }
            set
            {
                bizName = value;
            }
        }

        public string NationID
        {
            get
            {
                return nationID;
            }
            set
            {
                nationID = value;
            }
        }

        public decimal Capital
        {
            get
            {
                return capital;
            }
            set
            {
                capital = value;
            }
        }

        public string CDate
        {
            get
            {
                return cDate;
            }
            set
            {
                cDate = value;
            }
        }

        public string RegNo
        {
            get
            {
                return regNo;
            }
            set
            {
                regNo = value;
            }
        }

        public string RegDT
        {
            get
            {
                return regDT;
            }
            set
            {
                regDT = value;
            }
        }

        public string RegCity
        {
            get
            {
                return regCity;
            }
            set
            {
                regCity = value;
            }
        }

        public string LicenseStatus
        {
            get
            {
                return licenseStatus;
            }
            set
            {
                licenseStatus = value;
            }
        }

        public string LastLicenseType
        {
            get
            {
                return lastLicenseType;
            }
            set
            {
                lastLicenseType = value;
            }
        }

        public string LastLicenseNo
        {
            get
            {
                return lastLicenseNo;
            }
            set
            {
                lastLicenseNo = value;
            }
        }

        public string LastLicenseDT
        {
            get
            {
                return lastLicenseDT;
            }
            set
            {
                lastLicenseDT = value;
            }
        }

        public string LastLicenseExpDT
        {
            get
            {
                return lastLicenseExpDT;
            }
            set
            {
                lastLicenseExpDT = value;
            }
        }

        public string WTel
        {
            get
            {
                return wTel;
            }
            set
            {
                wTel = value;
            }
        }

        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }

        public string OwnType
        {
            get
            {
                return ownType;
            }
            set
            {
                ownType = value;
            }
        }

        public string StateCD
        {
            get
            {
                return stateCD;
            }
            set
            {
                stateCD = value;
            }
        }

        public string CityCD
        {
            get
            {
                return cityCD;
            }
            set
            {
                cityCD = value;
            }
        }

        public string Addr
        {
            get
            {
                return addr;
            }
            set
            {
                addr = value;
            }
        }

        public string ZipCD
        {
            get
            {
                return zipCD;
            }
            set
            {
                zipCD = value;
            }
        }

        public string LastLicenseTypeName
        {
            get
            {
                return lastLicenseTypeName;
            }
            set
            {
                lastLicenseTypeName = value;
            }
        }

        public string LicenseSTName
        {
            get
            {
                return licenseSTName;
            }
            set
            {
                licenseSTName = value;
            }
        }
    }
}
