﻿namespace DocumentServices.Modules.Readers.MsgReader
{
    /// <summary>
    /// This class contains all the language specific constants
    /// </summary>
    internal static class LanguageConsts
    {
        #region E-mail constants
        /// <summary>
        /// The E-mail FROM label
        /// </summary>
        public const string EmailFromLabel = "From";

        /// <summary>
        /// The E-mail SENT ON label
        /// </summary>
        public const string EmailSentOnLabel = "Sent on";

        /// <summary>
        /// The E-mail TO label
        /// </summary>
        public const string EmailToLabel = "To";

        /// <summary>
        /// The E-mail CC label
        /// </summary>
        public const string EmailCcLabel = "CC";

        /// <summary>
        /// The E-mail BCC label
        /// </summary>
        public const string EmailBccLabel = "BCC";

        //public const string receivedOnLabel = "Received on";

        /// <summary>
        /// The E-mail SUBJECT label
        /// </summary>
        public const string EmailSubjectLabel = "Subject";

        /// <summary>
        /// The E-mail ATTACHMENTS label
        /// </summary>
        public const string EmailAttachmentsLabel = "Attachments";

        /// <summary>
        /// The E-mail FLAG label
        /// </summary>
        public const string EmailFollowUpFlag = "Flag";

        /// <summary>
        /// The E-mail FOLLOW UP label
        /// </summary>
        public const string EmailFollowUpLabel = "Follow up";

        /// <summary>
        /// The E-mail FOLLOW UP STATUS label
        /// </summary>
        public const string EmailFollowUpStatusLabel = "Follow up status";

        /// <summary>
        /// The E-mail FOLLOW UP COMPLETED text
        /// </summary>
        public const string EmailFollowUpCompletedText = "Completed";

        /// <summary>
        /// The E-mail CATEGORIES label
        /// </summary>
        public const string EmailCategoriesLabel = "Categories";
        #endregion

        /// <summary>
        /// The culture format to use for a date
        /// </summary>
        public const string DateFormatCulture = "en-US";

        /// <summary>
        /// The format used for all date related items, use this in conjuction with the <see cref="DateFormatCulture"/>
        /// http://msdn.microsoft.com/en-us/library/az4se3k1%28v=vs.110%29.aspx
        /// </summary>
        public const string DataFormat = "F";

        /// <summary>
        /// Normally Outlook will use the subject of a MSG object as it filename. Invalid characters
        /// are replaced by spaces. When there is no subject outlook uses "Nameless" as default
        /// </summary>
        public const string NameLessFileName = "Nameless";

        #region StickyNote constants
        /// <summary>
        /// The sticky note date label 
        /// </summary>
        public const string StickyNoteDateLabel = "Date";
        #endregion

        #region Appointment constants
        /// <summary>
        /// The appointment SUBJECT label
        /// </summary>
        public const string AppointmentSubject = "Subject";

        /// <summary>
        /// The appointment LOCATION label
        /// </summary>
        public const string AppointmentLocation = "Location";

        /// <summary>
        /// The appointment START label
        /// </summary>
        public const string AppointmentStartDate = "Start";

        /// <summary>
        /// The appointment END label
        /// </summary>
        public const string AppointmentEndDate = "End";
        
        /// <summary>
        /// The appointment RECCURENCE TYPE label
        /// </summary>
        public const string AppointmentRecurrenceTypeLabel = "Recurrence patern";

        /// <summary>
        /// The appointment RECCURENCE PATERN label
        /// </summary>
        public const string AppointmentRecurrencePaternLabel = "Recurrence patern type";

        /// <summary>
        /// The appointment ORGANIZER label
        /// </summary>
        public const string AppointmentOrganizerLabel = "Organizer";

        /// <summary>
        /// The appointment MANDATORY PARTICIPANTS label
        /// </summary>
        public const string AppointmentMandatoryParticipantsLabel = "Mandatory participants";

        /// <summary>
        /// The appointment OPTIONAL PARTICIPANTS label
        /// </summary>
        public const string AppointmentOptionalParticipantsLabel = "Optional participants";

        /// <summary>
        /// The appointment CATEGORIES label
        /// </summary>
        public const string AppointmentCategoriesLabel = "Categories";

        /// <summary>
        /// The appointment RESOURCES label
        /// </summary>
        public const string AppointmentResourcesLabel = "Resources";

        /// <summary>
        /// The appointment RECCURENCE TYPE DAILY text
        /// </summary>
        public const string AppointmentReccurenceTypeDailyText = "Daily";

        /// <summary>
        /// The appointment RECCURENCE TYPE WEEKLY text
        /// </summary>
        public const string AppointmentReccurenceTypeWeeklyText = "Weekly";

        /// <summary>
        /// The appointment RECCURENCE TYPE MONTHLY text
        /// </summary>
        public const string AppointmentReccurenceTypeMonthlyText = "Monthly";

        /// <summary>
        /// The appointment RECCURENCE TYPE YEARLY text
        /// </summary>
        public const string AppointmentReccurenceTypeYearlyText = "Yearly";

        /// <summary>
        /// There is no RECURRENCE TYPE
        /// </summary>
        public const string AppointmentReccurenceTypeNone = "(None)";

        /// <summary>
        /// The appointment STATUS label
        /// </summary>
        public const string AppointmentStatusLabel = "Meeting status";

        /// <summary>
        /// The appointment STATUS
        /// </summary>
        public const string AppointmentStatusManager = "Organizer of the meeting";

        /// <summary>
        /// The appointment STATUS TENTATIVE
        /// </summary>
        public const string AppointmentStatusTentative = "Tentative";

        /// <summary>
        /// The appointment STATUS ACCEPT
        /// </summary>
        public const string AppointmentStatusAccept = "Accepted";

        /// <summary>
        /// The appointment STATUS DECLINE
        /// </summary>
        public const string AppointmentStatusDecline = "Declined";

        /// <summary>
        /// The appointment ATTACHMENTS label
        /// </summary>
        public const string AppointmentAttachmentsLabel = "Attachments";
        #endregion

        #region Task constants
        /// <summary>
        /// The TASK SUBJECT label
        /// </summary>
        public const string TaskSubject = "Subject";
        
        /// <summary>
        /// The TASK STARTDATE label
        /// </summary>
        public const string TaskStartDateLabel = "Start date";

        /// <summary>
        /// The TASK DUEDATE label
        /// </summary>
        public const string TaskDueDateLabel = "Due date";

        /// <summary>
        /// The TASK DATE COMPLETED label
        /// </summary>
        public const string TaskDateCompleted = "Completed on";

        /// <summary>
        /// The TASK STATUS label
        /// </summary>
        public const string TaskStatusLabel = "Status";

        /// <summary>
        /// The TASK TOTAL WORK label
        /// </summary>
        public const string TaskTotalWorkLabel = "Total work";

        /// <summary>
        /// The TASK ACTUAL WORK label
        /// </summary>
        public const string TaskActualWorkLabel = "Actual work";

        /// <summary>
        /// The TASK OWNER label
        /// </summary>
        public const string TaskOwnerLabel = "Owner";

        /// <summary>
        /// The TASK COMPANY label
        /// </summary>
        public const string TaskCompanyLabel = "Company";

        /// <summary>
        /// The TASK BILLING INFORMATION label
        /// </summary>
        public const string TaskBillingInformationLabel = "Billing information";

        /// <summary>
        /// The TASK MILEAGE label
        /// </summary>
        public const string TaskMileageLabel = "Mileage";

        /// <summary>
        /// The TASK REQUESTED BY label
        /// </summary>
        public const string TaskRequestedByLabel = "Requested by";
        #endregion

        #region Importance
        /// <summary>
        /// The IMPORTANCE label
        /// </summary>
        public const string ImportanceLabel = "Urgent";

        /// <summary>
        /// The IMPORTANCE low text
        /// </summary>
        public const string ImportanceLowText = "Low";

        /// <summary>
        /// The IMPORTANCE normal text
        /// </summary>
        public const string ImportanceNormalText = "Normal";

        /// <summary>
        /// The IMPORTANCE high text
        /// </summary>
        public const string ImportanceHighText = "High";

        #endregion
    }
}
