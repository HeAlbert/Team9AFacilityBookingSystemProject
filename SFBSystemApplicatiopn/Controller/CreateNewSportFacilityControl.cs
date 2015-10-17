using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace SFBSystemApplicatiopn
{
    public class CreateNewSportFacilityControl
    {
        private frmCreateNewSportsFacility createNewSportsFacility;

        public void selectCreateNewSportsFacility()
        {
            createNewSportsFacility = new frmCreateNewSportsFacility(this);
            createNewSportsFacility.Show();
        }
        public void SelectSave(SportFacility s)
        {
            SportsFacilityBookingEntities1 ent = new SportsFacilityBookingEntities1();
            ent.SportFacilities.Add(s);
            ent.SaveChanges();

        }
        public void SelectUpload()
        {
            
        }
        //convert Image to Byte[]
        public byte[] ImageToByte(Image image)
        {
            ImageFormat format = image.RawFormat;
            using (MemoryStream ms = new MemoryStream())
            {
                if (format.Equals(ImageFormat.Jpeg))
                {
                    image.Save(ms, ImageFormat.Jpeg);
                }
                else if (format.Equals(ImageFormat.Png))
                {
                    image.Save(ms, ImageFormat.Png);
                }
                else if (format.Equals(ImageFormat.Bmp))
                {
                    image.Save(ms, ImageFormat.Bmp);
                }
                else if (format.Equals(ImageFormat.Gif))
                {
                    image.Save(ms, ImageFormat.Gif);
                }
                else if (format.Equals(ImageFormat.Icon))
                {
                    image.Save(ms, ImageFormat.Icon);
                }
                byte[] buffer = new byte[ms.Length];
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }
        public void CreateNewSportFacility()
        {
            SportsFacilityBookingEntities1 ent = new SportsFacilityBookingEntities1();
            //get sportsType Info
            //var sportTypeq = from x in ent.SportTypes select (new {x.SportTypeID,x.SportTypeName });
            var sportTypeq = from x in ent.SportTypes select x;

            List<SportType> st = sportTypeq.ToList();

            createNewSportsFacility.AcceptSportsFacilityInfo(st);
            
        }

    }
}
