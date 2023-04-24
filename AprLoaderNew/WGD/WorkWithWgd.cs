using AprLoaderNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprLoaderNew.WGD
{
    public class WorkWithWgd
    {
        internal AnatomicRegion WGDAnatomicRegion;
        public WorkWithWgd()
        {

        }

        public void ClearDb()
        {
            using (var wgd = new WGDContext())
            {
                wgd.ImageOriginalParameters.RemoveRange(wgd.ImageOriginalParameters);
                wgd.PacsMovedImages.RemoveRange(wgd.PacsMovedImages);
                wgd.BackupFilePaths.RemoveRange(wgd.BackupFilePaths);
                wgd.UnsendedImages.RemoveRange(wgd.UnsendedImages);
                wgd.Images.RemoveRange(wgd.Images);
                wgd.Series.RemoveRange(wgd.Series);
                wgd.Examinations.RemoveRange(wgd.Examinations);
                wgd.AnatomicRegions.RemoveRange(wgd.AnatomicRegions);
                wgd.SaveChanges();
            }
        }

        public void ClearStudies()
        {
            using (var wgd = new WGDContext())
            {
                wgd.ImageOpticalParameters.RemoveRange(wgd.ImageOpticalParameters);
                wgd.ImageOriginalParameters.RemoveRange(wgd.ImageOriginalParameters);
                wgd.PacsMovedImages.RemoveRange(wgd.PacsMovedImages);
                wgd.BackupFilePaths.RemoveRange(wgd.BackupFilePaths);
                wgd.UnsendedImages.RemoveRange(wgd.UnsendedImages);
                wgd.DeletedImages.RemoveRange(wgd.DeletedImages);
                wgd.Studies.RemoveRange(wgd.Studies);
                wgd.EventLogs.RemoveRange(wgd.EventLogs);
                wgd.ModifiedPatients.RemoveRange(wgd.ModifiedPatients);
                wgd.ReportsSavedFiles.RemoveRange(wgd.ReportsSavedFiles);
                wgd.ModifiedPatientHistories.RemoveRange(wgd.ModifiedPatientHistories);
                wgd.Patients.RemoveRange(wgd.Patients);
                wgd.PatientDetaileds.RemoveRange(wgd.PatientDetaileds);
                wgd.Images.RemoveRange(wgd.Images);
                wgd.StudyAprs.RemoveRange(wgd.StudyAprs);
                wgd.Series.RemoveRange(wgd.Series);
                wgd.SaveChanges();
            }
        }

        public void UpdateAnatomicRegion(string AnatomicRegionCode, string CodeMeaning, string CodingScheme, int id)
        {
            using (var wgd = new WGDContext())
            {
                WGDAnatomicRegion = wgd.AnatomicRegions.FirstOrDefault(w => w.CodeValue == AnatomicRegionCode);
                if (WGDAnatomicRegion == null)
                {
                    var i = wgd.AnatomicRegions.Count();
                    WGDAnatomicRegion = new AnatomicRegion()
                    {
                        CodeValue = AnatomicRegionCode,
                        CodeMeaning = CodeMeaning,
                        CodeMeaningLoc = CodeMeaning,
                        CodingSchemeDesignator = CodingScheme,
                        Id = id
                    };
                    wgd.AnatomicRegions.Add(WGDAnatomicRegion);
                    wgd.SaveChanges();
                    WGDAnatomicRegion = wgd.AnatomicRegions.FirstOrDefault(w => w.CodeValue == AnatomicRegionCode);
                }
            }
        }

        public void UpdateExamination(string ExaminationName, string BodyPart, int id)
        {
            using (var wgd = new WGDContext())
            {
                var ExaminationWGD = wgd.Examinations.FirstOrDefault(w => w.Name == ExaminationName);
                if (ExaminationWGD == null)
                {
                    var i = wgd.Examinations.Count();
                    ExaminationWGD = new Examination()
                    {
                        Name = ExaminationName,
                        EmdName = ExaminationName,
                        CodeValue = WGDAnatomicRegion.CodeValue,
                        AnatomicRegionId = WGDAnatomicRegion.Id,
                        BodyPart = BodyPart,
                        Id = id
                    };
                    wgd.Examinations.Add(ExaminationWGD);
                    wgd.SaveChanges();
                }
            }
        }
    }
}
