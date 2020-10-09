using Microsoft.Extensions.DependencyInjection;

namespace DI
{
    public static class ServiceProviderExtensions
    {
        public static void AddTimeService(this IServiceCollection services)
        {
            services.AddTransient<TimeService>();
        }

        public static void AddEmailMessageService(this IServiceCollection services)
        {
            services.AddTransient<IMessageSender, EmailMessageSender>();
        }

        public static void AddSMSMessageService(this IServiceCollection services)
        {
            services.AddTransient<IMessageSender, SmsMessageSender>();
        }
    }
}