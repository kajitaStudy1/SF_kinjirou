using System.ComponentModel.DataAnnotations;

namespace AspNetCoreSpa.Server.Entities
{
    public enum ExternalLoginStatus
    {
        Ok = 0,
        Error = 1,
        Invalid = 2,
        TwoFactor = 3,
        Lockout = 4,
        CreateAccount = 5

    }

    /// <summary>
    /// 勤務種類
    /// </summary>
    public enum WorkingType
    {
        /// <summary>
        /// 未登録
        /// </summary>
        [Display(Name = "未登録")]
        Unregistered = 0,
        /// <summary>
        /// 出勤
        /// </summary>
        [Display(Name = "出勤")]
        Attendance = 1,
        /// <summary>
        /// 有給休暇
        /// </summary>
        [Display(Name = "有給休暇")]
        PaidHoliday = 20,
        /// <summary>
        /// 法内休日
        /// </summary>
        [Display(Name = "法内休日")]
        LegalHoliday = 10,
        /// <summary>
        /// 法定外休日
        /// </summary>
        [Display(Name = "法定外休日")]
        NonLegalHoliday = 11,

    }

}