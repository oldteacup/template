using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace CoreServiceTemplate.IServices
{
    public interface ILogService
    {

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Debug(Exception? exception, string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Debug(Exception? exception, string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Debug(string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Debug(string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Debug<T>(Exception? exception, string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Debug<T>(string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Debug<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Debug<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Debug<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Debug level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Error(Exception? exception, string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Error(Exception? exception, string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Error(string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Error(string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Error<T>(Exception? exception, string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Error<T>(string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Error<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Error<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Error level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Fatal(Exception? exception, string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Fatal(Exception? exception, string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Fatal(string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Fatal(string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Fatal<T>(Exception? exception, string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Fatal<T>(string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Fatal<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Fatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Fatal<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Fatal level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level and
        //     associated exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Information(Exception? exception, string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level and
        //     associated exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Information(Exception? exception, string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Information(string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Information(string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level and
        //     associated exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Information<T>(Exception? exception, string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Information<T>(string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level and
        //     associated exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Information<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level and
        //     associated exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Information<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Information level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Determine if events at the specified level will be passed through to the log
        //     sinks.
        //
        // 参数:
        //   level:
        //     Level to check.
        //
        // 返回结果:
        //     True if the level is enabled; otherwise, false.
        public bool IsEnabled(LogEventLevel level);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Verbose(Exception? exception, string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Verbose(Exception? exception, string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Verbose(string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Verbose(string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Verbose<T>(Exception? exception, string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Verbose<T>(string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Verbose<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Verbose<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Verbose<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Verbose level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Verbose<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Warning(Exception? exception, string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Warning(Exception? exception, string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Warning(string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Warning(string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Warning<T>(Exception? exception, string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Warning<T>(string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Warning<T0, T1, T2>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Warning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level and associated
        //     exception.
        //
        // 参数:
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Warning<T0, T1>(Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write a log event with the Serilog.Events.LogEventLevel.Warning level.
        //
        // 参数:
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write an event to the log.
        //
        // 参数:
        //   logEvent:
        //     The event to write.
        public void Write(LogEvent logEvent)
        {
            Log.Write(logEvent);
        }

        //
        // 摘要:
        //     Write a log event with the specified level and associated exception.
        //
        // 参数:
        //   level:
        //     The level of the event.
        //
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Write(LogEventLevel level, Exception? exception, string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the specified level and associated exception.
        //
        // 参数:
        //   level:
        //     The level of the event.
        //
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Write(LogEventLevel level, Exception? exception, string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the specified level.
        //
        // 参数:
        //   level:
        //     The level of the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Write(LogEventLevel level, string messageTemplate);

        //
        // 摘要:
        //     Write a log event with the specified level.
        //
        // 参数:
        //   level:
        //     The level of the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValues:
        //     Objects positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Write(LogEventLevel level, string messageTemplate, params object?[]? propertyValues);

        //
        // 摘要:
        //     Write a log event with the specified level and associated exception.
        //
        // 参数:
        //   level:
        //     The level of the event.
        //
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Write<T>(LogEventLevel level, Exception? exception, string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the specified level.
        //
        // 参数:
        //   level:
        //     The level of the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Write<T>(LogEventLevel level, string messageTemplate, T propertyValue);

        //
        // 摘要:
        //     Write a log event with the specified level and associated exception.
        //
        // 参数:
        //   level:
        //     The level of the event.
        //
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Write<T0, T1, T2>(LogEventLevel level, Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the specified level.
        //
        // 参数:
        //   level:
        //     The level of the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue2:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Write<T0, T1, T2>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);

        //
        // 摘要:
        //     Write a log event with the specified level and associated exception.
        //
        // 参数:
        //   level:
        //     The level of the event.
        //
        //   exception:
        //     Exception related to the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Write<T0, T1>(LogEventLevel level, Exception? exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        //
        // 摘要:
        //     Write a log event with the specified level.
        //
        // 参数:
        //   level:
        //     The level of the event.
        //
        //   messageTemplate:
        //     Message template describing the event.
        //
        //   propertyValue0:
        //     Object positionally formatted into the message template.
        //
        //   propertyValue1:
        //     Object positionally formatted into the message template.
        [MessageTemplateFormatMethod("messageTemplate")]
        public void Write<T0, T1>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1);

    }
}
