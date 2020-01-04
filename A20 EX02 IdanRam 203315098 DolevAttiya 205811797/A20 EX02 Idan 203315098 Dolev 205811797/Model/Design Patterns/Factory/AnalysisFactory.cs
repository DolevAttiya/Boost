using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Documents;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.DataClasses;
using A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator;
using FacebookWrapper.ObjectModel;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Factory
{
    public class AnalysisFactory : IAnalysisFactory
    {
        public virtual SortedValueDictionary<object, int> CreateAnalysis(
            Post.eType i_Type,
            User i_User,
            eTimeSelector i_TimeSelector,
            Type i_FactoryToCreate)
        {
            SortedValueDictionary<object, int> o_Dictionary;
            string className = $"{nameof(i_Type)}DictionaryFactory";
            string methodName = $"Create{nameof(i_Type)}{i_FactoryToCreate.Name}AnalysisDictionary";
            Type dictionaryFactoryClass = null;
            MethodInfo createDictionaryMethod = null;
            
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if(type.Name == className)
                {
                    dictionaryFactoryClass = type;
                    break;
                }
            }

            foreach(MethodInfo method in dictionaryFactoryClass.GetMethods())
            {
                if(method.Name == methodName)
                {
                    createDictionaryMethod = method;
                    break;
                }
            }

            object[] passingParameters= { i_User, i_TimeSelector };

                
                o_Dictionary = (SortedValueDictionary<object, int>)createDictionaryMethod.Invoke(this, passingParameters);

                return o_Dictionary;
        }
    }
}