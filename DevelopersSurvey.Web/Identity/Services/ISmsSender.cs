// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISmsSender.cs" company="Peaceful Dev">
//   Copyrights by Peaceful Dev 2017
// </copyright>
// <summary>
//   Defines the ISmsSender type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DevelopersSurvey.Web.Identity.Services
{
    using System.Threading.Tasks;

    /// <summary>
    /// The SmsSender interface.
    /// </summary>
    public interface ISmsSender
    {
        /// <summary>
        /// The send sms async.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task SendSmsAsync(string number, string message);
    }
}
