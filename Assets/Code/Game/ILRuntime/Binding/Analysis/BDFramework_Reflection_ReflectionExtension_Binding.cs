using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class BDFramework_Reflection_ReflectionExtension_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            MethodBase method;
            Type[] args;
            Type type = typeof(BDFramework.Reflection.ReflectionExtension);
            Dictionary<string, List<MethodInfo>> genericMethods = new Dictionary<string, List<MethodInfo>>();
            List<MethodInfo> lst = null;                    
            foreach(var m in type.GetMethods())
            {
                if(m.IsGenericMethodDefinition)
                {
                    if (!genericMethods.TryGetValue(m.Name, out lst))
                    {
                        lst = new List<MethodInfo>();
                        genericMethods[m.Name] = lst;
                    }
                    lst.Add(m);
                }
            }
            args = new Type[]{typeof(ILRuntime.Runtime.Adapters.AttributeAdapter.Adapter)};
            if (genericMethods.TryGetValue("GetAttributeInILRuntime", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(ILRuntime.Runtime.Adapters.AttributeAdapter.Adapter), typeof(System.Reflection.MemberInfo)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, GetAttributeInILRuntime_0);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(BDFramework.UnitTest.UnitTestBaseAttribute)};
            if (genericMethods.TryGetValue("GetAttributeInILRuntime", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(BDFramework.UnitTest.UnitTestBaseAttribute), typeof(System.Reflection.MemberInfo)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, GetAttributeInILRuntime_1);

                        break;
                    }
                }
            }


        }


        static StackObject* GetAttributeInILRuntime_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Reflection.MemberInfo @memberInfo = (System.Reflection.MemberInfo)typeof(System.Reflection.MemberInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = BDFramework.Reflection.ReflectionExtension.GetAttributeInILRuntime<ILRuntime.Runtime.Adapters.AttributeAdapter.Adapter>(@memberInfo);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAttributeInILRuntime_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Reflection.MemberInfo @memberInfo = (System.Reflection.MemberInfo)typeof(System.Reflection.MemberInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = BDFramework.Reflection.ReflectionExtension.GetAttributeInILRuntime<BDFramework.UnitTest.UnitTestBaseAttribute>(@memberInfo);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}