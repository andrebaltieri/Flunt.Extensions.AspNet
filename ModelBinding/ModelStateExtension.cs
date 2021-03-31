using System.Collections.Generic;
using Flunt.Notifications;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Flunt.Extensions.AspNet.ModelBinding
{
    public static class ModelStateExtension
    {
        public static void AddNotifications(this ModelStateDictionary modelState, IReadOnlyCollection<Notification> notifications)
        {
            foreach (var notification in notifications)
                modelState.AddModelError(notification.Key, notification.Message);
        }
    }
}