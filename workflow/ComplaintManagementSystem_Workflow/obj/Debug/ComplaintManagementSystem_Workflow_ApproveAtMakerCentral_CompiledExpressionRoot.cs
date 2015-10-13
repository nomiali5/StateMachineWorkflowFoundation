namespace ComplaintManagementSystem_Workflow {
    
    #line 21 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\ApproveAtMakerCentral.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\ApproveAtMakerCentral.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 22 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\ApproveAtMakerCentral.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\ApproveAtMakerCentral.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\ApproveAtMakerCentral.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\ApproveAtMakerCentral.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 23 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\ApproveAtMakerCentral.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 24 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\ApproveAtMakerCentral.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 25 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\ApproveAtMakerCentral.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\ApproveAtMakerCentral.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class ApproveAtMakerCentral : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext0 = ((ApproveAtMakerCentral_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext1 = ((ApproveAtMakerCentral_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApproveAtMakerCentral_TypedDataContext2(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2 refDataContext2 = ((ApproveAtMakerCentral_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext3 = ((ApproveAtMakerCentral_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApproveAtMakerCentral_TypedDataContext2(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2 refDataContext4 = ((ApproveAtMakerCentral_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<bool>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApproveAtMakerCentral_TypedDataContext2(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2 refDataContext5 = ((ApproveAtMakerCentral_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<bool>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext6 = ((ApproveAtMakerCentral_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApproveAtMakerCentral_TypedDataContext2(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2 refDataContext7 = ((ApproveAtMakerCentral_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext8 = ((ApproveAtMakerCentral_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApproveAtMakerCentral_TypedDataContext2(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2 refDataContext9 = ((ApproveAtMakerCentral_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApproveAtMakerCentral_TypedDataContext2(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2 refDataContext10 = ((ApproveAtMakerCentral_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext10.GetLocation<bool>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApproveAtMakerCentral_TypedDataContext2(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2 refDataContext11 = ((ApproveAtMakerCentral_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext11.GetLocation<bool>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext12 = ((ApproveAtMakerCentral_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApproveAtMakerCentral_TypedDataContext2(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2 refDataContext13 = ((ApproveAtMakerCentral_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext13.GetLocation<string>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApproveAtMakerCentral_TypedDataContext2(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2 refDataContext14 = ((ApproveAtMakerCentral_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext14.GetLocation<bool>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApproveAtMakerCentral_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApproveAtMakerCentral_TypedDataContext2(locations, activityContext, true);
                }
                ApproveAtMakerCentral_TypedDataContext2 refDataContext15 = ((ApproveAtMakerCentral_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext15.GetLocation<bool>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext0 = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext1 = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                ApproveAtMakerCentral_TypedDataContext2 refDataContext2 = new ApproveAtMakerCentral_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext3 = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                ApproveAtMakerCentral_TypedDataContext2 refDataContext4 = new ApproveAtMakerCentral_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<bool>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                ApproveAtMakerCentral_TypedDataContext2 refDataContext5 = new ApproveAtMakerCentral_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<bool>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext6 = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                ApproveAtMakerCentral_TypedDataContext2 refDataContext7 = new ApproveAtMakerCentral_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext8 = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                ApproveAtMakerCentral_TypedDataContext2 refDataContext9 = new ApproveAtMakerCentral_TypedDataContext2(locations, true);
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                ApproveAtMakerCentral_TypedDataContext2 refDataContext10 = new ApproveAtMakerCentral_TypedDataContext2(locations, true);
                return refDataContext10.GetLocation<bool>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                ApproveAtMakerCentral_TypedDataContext2 refDataContext11 = new ApproveAtMakerCentral_TypedDataContext2(locations, true);
                return refDataContext11.GetLocation<bool>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                ApproveAtMakerCentral_TypedDataContext2_ForReadOnly valDataContext12 = new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                ApproveAtMakerCentral_TypedDataContext2 refDataContext13 = new ApproveAtMakerCentral_TypedDataContext2(locations, true);
                return refDataContext13.GetLocation<string>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                ApproveAtMakerCentral_TypedDataContext2 refDataContext14 = new ApproveAtMakerCentral_TypedDataContext2(locations, true);
                return refDataContext14.GetLocation<bool>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                ApproveAtMakerCentral_TypedDataContext2 refDataContext15 = new ApproveAtMakerCentral_TypedDataContext2(locations, true);
                return refDataContext15.GetLocation<bool>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "\"Provided Document: \" + ProvidedDocument +\n\" -> Maker Central: Enter Status? 1 fo" +
                            "r accept, 2 for reject, 3 send back to maker\"") 
                        && (ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Convert.ToInt32(Console.ReadLine());") 
                        && (ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "getVerified") 
                        && (ApproveAtMakerCentral_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "getVerified") 
                        && (ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isApproveAtMakerCentral") 
                        && (ApproveAtMakerCentral_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "sendBackToMaker") 
                        && (ApproveAtMakerCentral_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "null") 
                        && (ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "rejectionComments") 
                        && (ApproveAtMakerCentral_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "rejectionComments") 
                        && (ApproveAtMakerCentral_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isApproveAtMakerCentral") 
                        && (ApproveAtMakerCentral_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "sendBackToMaker") 
                        && (ApproveAtMakerCentral_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (ApproveAtMakerCentral_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "rejectionComments") 
                        && (ApproveAtMakerCentral_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isApproveAtMakerCentral") 
                        && (ApproveAtMakerCentral_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "sendBackToMaker") 
                        && (ApproveAtMakerCentral_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new ApproveAtMakerCentral_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new ApproveAtMakerCentral_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new ApproveAtMakerCentral_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new ApproveAtMakerCentral_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new ApproveAtMakerCentral_TypedDataContext2(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new ApproveAtMakerCentral_TypedDataContext2(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new ApproveAtMakerCentral_TypedDataContext2(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new ApproveAtMakerCentral_TypedDataContext2(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new ApproveAtMakerCentral_TypedDataContext2(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new ApproveAtMakerCentral_TypedDataContext2(locationReferences).@__Expr15GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApproveAtMakerCentral_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApproveAtMakerCentral_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApproveAtMakerCentral_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApproveAtMakerCentral_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApproveAtMakerCentral_TypedDataContext1 : ApproveAtMakerCentral_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool isApproveAtMakerCentral;
            
            protected bool sendBackToMaker;
            
            public ApproveAtMakerCentral_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string ProvidedDocument {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string rejectionComments {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.isApproveAtMakerCentral = ((bool)(this.GetVariableValue((0 + locationsOffset))));
                this.sendBackToMaker = ((bool)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.isApproveAtMakerCentral);
                this.SetVariableValue((2 + locationsOffset), this.sendBackToMaker);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 1)].Name != "ProvidedDocument") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "rejectionComments") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "isApproveAtMakerCentral") 
                            || (locationReferences[(offset + 0)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "sendBackToMaker") 
                            || (locationReferences[(offset + 2)].Type != typeof(bool)))) {
                    return false;
                }
                return ApproveAtMakerCentral_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApproveAtMakerCentral_TypedDataContext1_ForReadOnly : ApproveAtMakerCentral_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool isApproveAtMakerCentral;
            
            protected bool sendBackToMaker;
            
            public ApproveAtMakerCentral_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string ProvidedDocument {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string rejectionComments {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.isApproveAtMakerCentral = ((bool)(this.GetVariableValue((0 + locationsOffset))));
                this.sendBackToMaker = ((bool)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 1)].Name != "ProvidedDocument") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "rejectionComments") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "isApproveAtMakerCentral") 
                            || (locationReferences[(offset + 0)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "sendBackToMaker") 
                            || (locationReferences[(offset + 2)].Type != typeof(bool)))) {
                    return false;
                }
                return ApproveAtMakerCentral_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApproveAtMakerCentral_TypedDataContext2 : ApproveAtMakerCentral_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int getVerified;
            
            public ApproveAtMakerCentral_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string CriteriaForMakerCentral {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 58 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          getVerified;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr2Get() {
                
                #line 58 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
          getVerified;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(int value) {
                
                #line 58 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                
          getVerified = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 78 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              isApproveAtMakerCentral;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 78 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              isApproveAtMakerCentral;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(bool value) {
                
                #line 78 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                
              isApproveAtMakerCentral = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 88 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              sendBackToMaker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 88 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              sendBackToMaker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(bool value) {
                
                #line 88 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                
              sendBackToMaker = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 98 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              rejectionComments;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 98 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              rejectionComments;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(string value) {
                
                #line 98 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                
              rejectionComments = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 114 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              rejectionComments;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 114 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              rejectionComments;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(string value) {
                
                #line 114 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                
              rejectionComments = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 126 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              isApproveAtMakerCentral;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr10Get() {
                
                #line 126 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              isApproveAtMakerCentral;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(bool value) {
                
                #line 126 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                
              isApproveAtMakerCentral = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 136 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              sendBackToMaker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr11Get() {
                
                #line 136 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              sendBackToMaker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(bool value) {
                
                #line 136 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                
              sendBackToMaker = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 150 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              rejectionComments;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 150 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              rejectionComments;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(string value) {
                
                #line 150 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                
              rejectionComments = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 162 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              isApproveAtMakerCentral;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 162 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              isApproveAtMakerCentral;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(bool value) {
                
                #line 162 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                
              isApproveAtMakerCentral = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 172 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              sendBackToMaker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr15Get() {
                
                #line 172 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              sendBackToMaker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(bool value) {
                
                #line 172 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                
              sendBackToMaker = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.getVerified = ((int)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.getVerified);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 4)].Name != "CriteriaForMakerCentral") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "getVerified") 
                            || (locationReferences[(offset + 5)].Type != typeof(int)))) {
                    return false;
                }
                return ApproveAtMakerCentral_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApproveAtMakerCentral_TypedDataContext2_ForReadOnly : ApproveAtMakerCentral_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int getVerified;
            
            public ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApproveAtMakerCentral_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string CriteriaForMakerCentral {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 51 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
        "Provided Document: " + ProvidedDocument +
" -> Maker Central: Enter Status? 1 for accept, 2 for reject, 3 send back to maker";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 51 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
        "Provided Document: " + ProvidedDocument +
" -> Maker Central: Enter Status? 1 for accept, 2 for reject, 3 send back to maker";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 63 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          Convert.ToInt32(Console.ReadLine());;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr1Get() {
                
                #line 63 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
          Convert.ToInt32(Console.ReadLine());;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 70 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          getVerified;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr3Get() {
                
                #line 70 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
          getVerified;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 103 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr6Get() {
                
                #line 103 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              null;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 119 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr8Get() {
                
                #line 119 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 155 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 155 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\APPROVEATMAKERCENTRAL.XAML"
                return 
              Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            protected override void GetValueTypeValues() {
                this.getVerified = ((int)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 4)].Name != "CriteriaForMakerCentral") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "getVerified") 
                            || (locationReferences[(offset + 5)].Type != typeof(int)))) {
                    return false;
                }
                return ApproveAtMakerCentral_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
