using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailerForDereje
{
    class EmailDetails
    {
        public  static string fromMail = Login.email;
        public static string fromPass = Login.pass;
        public const string fromName = "Dustin Hailie";
        public const string Subject = "Final email test!";
        //

        public static string Body(string first, string last, string email)
        {
            return $"Dear {first},\nThank you for taking the MGU-PM 100 Foundations of Project Management online course. Your certificate of completion is attached to this email. We would also like to provide clarification on the following items:\n\n\n·      This certificate is a verification that you have attended the 12-week online training. It is not verification that you have passed the PMP exam.\n·      This certificate of completion will fulfil the 35-hour professional training requirement if you plan to register for the Project Management Institute (PMI) Project Management Professional (PMP) exam.  \nWe at Maryland Global University Inc (MGU), a Project Management Institute Global Educational Provider, are happy to have had the opportunity to provide you with this professional training. MGU partnered with Digital Africa LLC, a Learning Management System vendor, and Teach and Serve for Africa/Ethiopian Diaspora Service Initiative (TASFA/EDSI) to offer you this free training. We hope you will use the knowledge, skills, and techniques captured from this course towards ensuring the successful management of projects.\n\n\nPlease feel free to contact us at info@mdgu.us (844-235-0220) if you have any questions.\nRegards,\nAbenzer Endale,\nMGU, Technical and Training Lead";

        }

    }
}
