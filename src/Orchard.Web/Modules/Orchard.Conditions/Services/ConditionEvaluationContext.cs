namespace Orchard.Conditions.Services {
    public class ConditionEvaluationContext {
        public string FunctionName { get; set; }
        public object[] Arguments { get; set; }
        public object Result { get; set; }
    }
}