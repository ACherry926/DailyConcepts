using OptionalParameter;

namespace Day10Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            ParametersExample();
            ParameterDefaults();
            MethodOverLoadingParameter();
            NamedParameters();
            OptionalAttribute();
            OverrideToStringMethod();
            ConvertToStringAndToString();
            StringAndStringBuilder();
        }

        static void ParametersExample()
        {
            Parameter parameter = new Parameter();
            parameter.ParametersExample();
        }

        static void ParameterDefaults()
        {
            ParameterDefault parameterDefault = new ParameterDefault();
            parameterDefault.ParameterDefaults();
        }

        static void MethodOverLoadingParameter()
        {
            MethodOverLoading methodOverLoading = new MethodOverLoading();
            methodOverLoading.MethodOverLoadingParameter();
        }

        static void NamedParameters()
        {
            NamedParameter namedParameter = new NamedParameter();
            namedParameter.NamedParameters();
            namedParameter.NamedParameters();
        }

        static void OptionalAttribute()
        {
            OptionalAttributes optionalAttributeExample = new OptionalAttributes();
            optionalAttributeExample.OptionalAttribute();
        }

        static void OverrideToStringMethod()
        {
            OverrideToStringMethodExamples overrideToStringMethodExamples = new OverrideToStringMethodExamples();
            overrideToStringMethodExamples.OverrideToStringMethod();
        }

        static void ConvertToStringAndToString()
        {
            ConvertToString convertToString = new ConvertToString();
            convertToString.ConvertToStringAndToString();
        }
        
        static void StringAndStringBuilder()
        {
            StringAndStringBuilder stringAndStringBuilderConcepts = new StringAndStringBuilder();
            stringAndStringBuilderConcepts.StringAndStringBuilderExample();
        }
    }
}
