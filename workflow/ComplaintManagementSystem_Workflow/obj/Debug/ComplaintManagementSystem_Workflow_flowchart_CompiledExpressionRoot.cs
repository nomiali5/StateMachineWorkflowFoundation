namespace ComplaintManagementSystem_Workflow {
    
    #line 23 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\flowchart.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\flowchart.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 24 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\flowchart.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\flowchart.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\flowchart.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\flowchart.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 25 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\flowchart.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 26 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\flowchart.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 27 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\flowchart.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\nouman.ali\Desktop\Workflow\workflow\ComplaintManagementSystem_Workflow\flowchart.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class flowchart : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = flowchart_TypedDataContext3.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new flowchart_TypedDataContext3(locations, activityContext, true);
                }
                flowchart_TypedDataContext3 refDataContext0 = ((flowchart_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<string>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new flowchart_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext3_ForReadOnly valDataContext1 = ((flowchart_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new flowchart_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext3_ForReadOnly valDataContext2 = ((flowchart_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new flowchart_TypedDataContext3(locations, activityContext, true);
                }
                flowchart_TypedDataContext3 refDataContext3 = ((flowchart_TypedDataContext3)(cachedCompiledDataContext[0]));
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new flowchart_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext3_ForReadOnly valDataContext4 = ((flowchart_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new flowchart_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext3_ForReadOnly valDataContext5 = ((flowchart_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new flowchart_TypedDataContext5(locations, activityContext, true);
                }
                flowchart_TypedDataContext5 refDataContext6 = ((flowchart_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new flowchart_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext5_ForReadOnly valDataContext7 = ((flowchart_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new flowchart_TypedDataContext5(locations, activityContext, true);
                }
                flowchart_TypedDataContext5 refDataContext8 = ((flowchart_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext8.GetLocation<bool>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new flowchart_TypedDataContext5(locations, activityContext, true);
                }
                flowchart_TypedDataContext5 refDataContext9 = ((flowchart_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new flowchart_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext5_ForReadOnly valDataContext10 = ((flowchart_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new flowchart_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext5_ForReadOnly valDataContext11 = ((flowchart_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new flowchart_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext5_ForReadOnly valDataContext12 = ((flowchart_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new flowchart_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext5_ForReadOnly valDataContext13 = ((flowchart_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new flowchart_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext5_ForReadOnly valDataContext14 = ((flowchart_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new flowchart_TypedDataContext7(locations, activityContext, true);
                }
                flowchart_TypedDataContext7 refDataContext15 = ((flowchart_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext15.GetLocation<bool>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new flowchart_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext7_ForReadOnly valDataContext16 = ((flowchart_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new flowchart_TypedDataContext7(locations, activityContext, true);
                }
                flowchart_TypedDataContext7 refDataContext17 = ((flowchart_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext17.GetLocation<bool>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new flowchart_TypedDataContext7(locations, activityContext, true);
                }
                flowchart_TypedDataContext7 refDataContext18 = ((flowchart_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext18.GetLocation<string>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new flowchart_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext7_ForReadOnly valDataContext19 = ((flowchart_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new flowchart_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext7_ForReadOnly valDataContext20 = ((flowchart_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new flowchart_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext7_ForReadOnly valDataContext21 = ((flowchart_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new flowchart_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext7_ForReadOnly valDataContext22 = ((flowchart_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new flowchart_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext7_ForReadOnly valDataContext23 = ((flowchart_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new flowchart_TypedDataContext9(locations, activityContext, true);
                }
                flowchart_TypedDataContext9 refDataContext24 = ((flowchart_TypedDataContext9)(cachedCompiledDataContext[6]));
                return refDataContext24.GetLocation<bool>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new flowchart_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext9_ForReadOnly valDataContext25 = ((flowchart_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new flowchart_TypedDataContext9(locations, activityContext, true);
                }
                flowchart_TypedDataContext9 refDataContext26 = ((flowchart_TypedDataContext9)(cachedCompiledDataContext[6]));
                return refDataContext26.GetLocation<bool>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new flowchart_TypedDataContext9(locations, activityContext, true);
                }
                flowchart_TypedDataContext9 refDataContext27 = ((flowchart_TypedDataContext9)(cachedCompiledDataContext[6]));
                return refDataContext27.GetLocation<bool>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new flowchart_TypedDataContext9(locations, activityContext, true);
                }
                flowchart_TypedDataContext9 refDataContext28 = ((flowchart_TypedDataContext9)(cachedCompiledDataContext[6]));
                return refDataContext28.GetLocation<string>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new flowchart_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext9_ForReadOnly valDataContext29 = ((flowchart_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new flowchart_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext9_ForReadOnly valDataContext30 = ((flowchart_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new flowchart_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext9_ForReadOnly valDataContext31 = ((flowchart_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new flowchart_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext9_ForReadOnly valDataContext32 = ((flowchart_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new flowchart_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext9_ForReadOnly valDataContext33 = ((flowchart_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new flowchart_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext9_ForReadOnly valDataContext34 = ((flowchart_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new flowchart_TypedDataContext10(locations, activityContext, true);
                }
                flowchart_TypedDataContext10 refDataContext35 = ((flowchart_TypedDataContext10)(cachedCompiledDataContext[8]));
                return refDataContext35.GetLocation<bool>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new flowchart_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext10_ForReadOnly valDataContext36 = ((flowchart_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext10.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new flowchart_TypedDataContext10(locations, activityContext, true);
                }
                flowchart_TypedDataContext10 refDataContext37 = ((flowchart_TypedDataContext10)(cachedCompiledDataContext[8]));
                return refDataContext37.GetLocation<string>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new flowchart_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext10_ForReadOnly valDataContext38 = ((flowchart_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new flowchart_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext10_ForReadOnly valDataContext39 = ((flowchart_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new flowchart_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext10_ForReadOnly valDataContext40 = ((flowchart_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = flowchart_TypedDataContext10_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new flowchart_TypedDataContext10_ForReadOnly(locations, activityContext, true);
                }
                flowchart_TypedDataContext10_ForReadOnly valDataContext41 = ((flowchart_TypedDataContext10_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext41.ValueType___Expr41Get();
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
                flowchart_TypedDataContext3 refDataContext0 = new flowchart_TypedDataContext3(locations, true);
                return refDataContext0.GetLocation<string>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                flowchart_TypedDataContext3_ForReadOnly valDataContext1 = new flowchart_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                flowchart_TypedDataContext3_ForReadOnly valDataContext2 = new flowchart_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                flowchart_TypedDataContext3 refDataContext3 = new flowchart_TypedDataContext3(locations, true);
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                flowchart_TypedDataContext3_ForReadOnly valDataContext4 = new flowchart_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                flowchart_TypedDataContext3_ForReadOnly valDataContext5 = new flowchart_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                flowchart_TypedDataContext5 refDataContext6 = new flowchart_TypedDataContext5(locations, true);
                return refDataContext6.GetLocation<bool>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                flowchart_TypedDataContext5_ForReadOnly valDataContext7 = new flowchart_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                flowchart_TypedDataContext5 refDataContext8 = new flowchart_TypedDataContext5(locations, true);
                return refDataContext8.GetLocation<bool>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                flowchart_TypedDataContext5 refDataContext9 = new flowchart_TypedDataContext5(locations, true);
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                flowchart_TypedDataContext5_ForReadOnly valDataContext10 = new flowchart_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                flowchart_TypedDataContext5_ForReadOnly valDataContext11 = new flowchart_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                flowchart_TypedDataContext5_ForReadOnly valDataContext12 = new flowchart_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                flowchart_TypedDataContext5_ForReadOnly valDataContext13 = new flowchart_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                flowchart_TypedDataContext5_ForReadOnly valDataContext14 = new flowchart_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                flowchart_TypedDataContext7 refDataContext15 = new flowchart_TypedDataContext7(locations, true);
                return refDataContext15.GetLocation<bool>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                flowchart_TypedDataContext7_ForReadOnly valDataContext16 = new flowchart_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                flowchart_TypedDataContext7 refDataContext17 = new flowchart_TypedDataContext7(locations, true);
                return refDataContext17.GetLocation<bool>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                flowchart_TypedDataContext7 refDataContext18 = new flowchart_TypedDataContext7(locations, true);
                return refDataContext18.GetLocation<string>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                flowchart_TypedDataContext7_ForReadOnly valDataContext19 = new flowchart_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                flowchart_TypedDataContext7_ForReadOnly valDataContext20 = new flowchart_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                flowchart_TypedDataContext7_ForReadOnly valDataContext21 = new flowchart_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                flowchart_TypedDataContext7_ForReadOnly valDataContext22 = new flowchart_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                flowchart_TypedDataContext7_ForReadOnly valDataContext23 = new flowchart_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                flowchart_TypedDataContext9 refDataContext24 = new flowchart_TypedDataContext9(locations, true);
                return refDataContext24.GetLocation<bool>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                flowchart_TypedDataContext9_ForReadOnly valDataContext25 = new flowchart_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                flowchart_TypedDataContext9 refDataContext26 = new flowchart_TypedDataContext9(locations, true);
                return refDataContext26.GetLocation<bool>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                flowchart_TypedDataContext9 refDataContext27 = new flowchart_TypedDataContext9(locations, true);
                return refDataContext27.GetLocation<bool>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                flowchart_TypedDataContext9 refDataContext28 = new flowchart_TypedDataContext9(locations, true);
                return refDataContext28.GetLocation<string>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                flowchart_TypedDataContext9_ForReadOnly valDataContext29 = new flowchart_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                flowchart_TypedDataContext9_ForReadOnly valDataContext30 = new flowchart_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                flowchart_TypedDataContext9_ForReadOnly valDataContext31 = new flowchart_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                flowchart_TypedDataContext9_ForReadOnly valDataContext32 = new flowchart_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                flowchart_TypedDataContext9_ForReadOnly valDataContext33 = new flowchart_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                flowchart_TypedDataContext9_ForReadOnly valDataContext34 = new flowchart_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                flowchart_TypedDataContext10 refDataContext35 = new flowchart_TypedDataContext10(locations, true);
                return refDataContext35.GetLocation<bool>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                flowchart_TypedDataContext10_ForReadOnly valDataContext36 = new flowchart_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                flowchart_TypedDataContext10 refDataContext37 = new flowchart_TypedDataContext10(locations, true);
                return refDataContext37.GetLocation<string>(refDataContext37.ValueType___Expr37Get, refDataContext37.ValueType___Expr37Set);
            }
            if ((expressionId == 38)) {
                flowchart_TypedDataContext10_ForReadOnly valDataContext38 = new flowchart_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                flowchart_TypedDataContext10_ForReadOnly valDataContext39 = new flowchart_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                flowchart_TypedDataContext10_ForReadOnly valDataContext40 = new flowchart_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                flowchart_TypedDataContext10_ForReadOnly valDataContext41 = new flowchart_TypedDataContext10_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "ProvidedDocument") 
                        && (flowchart_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CommentAll") 
                        && (flowchart_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "null") 
                        && (flowchart_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CommentAll") 
                        && (flowchart_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!String.IsNullOrEmpty(CommentAll)") 
                        && (flowchart_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Rejection Reason:\" + CommentAll") 
                        && (flowchart_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isApprovedAtMakerCentral") 
                        && (flowchart_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ProvidedDocument") 
                        && (flowchart_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "sendBackToMaker") 
                        && (flowchart_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CommentAll") 
                        && (flowchart_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!string.IsNullOrEmpty(CommentAll)") 
                        && (flowchart_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Rejection Reason:\"+ CommentAll") 
                        && (flowchart_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!isApprovedAtMakerCentral && !sendBackToMaker") 
                        && (flowchart_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isApprovedAtMakerCentral && !sendBackToMaker") 
                        && (flowchart_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!isApprovedAtMakerCentral && sendBackToMaker") 
                        && (flowchart_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isApprovedAtCheckerCentral") 
                        && (flowchart_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ProvidedDocument") 
                        && (flowchart_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "sendBackToChecker") 
                        && (flowchart_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CommentAll") 
                        && (flowchart_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!String.IsNullOrEmpty(CommentAll)") 
                        && (flowchart_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Rejection Reason\" + CommentAll") 
                        && (flowchart_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!isApprovedAtCheckerCentral && !sendBackToChecker") 
                        && (flowchart_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!isApprovedAtCheckerCentral && sendBackToChecker") 
                        && (flowchart_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isApprovedAtCheckerCentral && !sendBackToChecker") 
                        && (flowchart_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isFinallyApproved") 
                        && (flowchart_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ProvidedDocument") 
                        && (flowchart_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "sendBackToChecker") 
                        && (flowchart_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "sendBackToMaker") 
                        && (flowchart_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CommentAll") 
                        && (flowchart_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!String.IsNullOrEmpty(CommentAll)") 
                        && (flowchart_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Rejection Reason:\" + CommentAll") 
                        && (flowchart_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!isFinallyApproved && !sendBackToMaker && !sendBackToChecker") 
                        && (flowchart_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!isFinallyApproved && !sendBackToMaker && sendBackToChecker") 
                        && (flowchart_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isFinallyApproved && !sendBackToMaker && !sendBackToChecker") 
                        && (flowchart_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!isFinallyApproved && sendBackToMaker && !sendBackToChecker") 
                        && (flowchart_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "isApprovedAtChecker") 
                        && (flowchart_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ProvidedDocument") 
                        && (flowchart_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CommentAll") 
                        && (flowchart_TypedDataContext10.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!String.IsNullOrEmpty(CommentAll)") 
                        && (flowchart_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Rejection Reason:\" + CommentAll") 
                        && (flowchart_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!isApprovedAtChecker") 
                        && (flowchart_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "isApprovedAtChecker") 
                        && (flowchart_TypedDataContext10_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
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
                return new flowchart_TypedDataContext3(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new flowchart_TypedDataContext3_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new flowchart_TypedDataContext3_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new flowchart_TypedDataContext3(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new flowchart_TypedDataContext3_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new flowchart_TypedDataContext3_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new flowchart_TypedDataContext5(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new flowchart_TypedDataContext5_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new flowchart_TypedDataContext5(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new flowchart_TypedDataContext5(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new flowchart_TypedDataContext5_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new flowchart_TypedDataContext5_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new flowchart_TypedDataContext5_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new flowchart_TypedDataContext5_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new flowchart_TypedDataContext5_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new flowchart_TypedDataContext7(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new flowchart_TypedDataContext7_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new flowchart_TypedDataContext7(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new flowchart_TypedDataContext7(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new flowchart_TypedDataContext7_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new flowchart_TypedDataContext7_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new flowchart_TypedDataContext7_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new flowchart_TypedDataContext7_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new flowchart_TypedDataContext7_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new flowchart_TypedDataContext9(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new flowchart_TypedDataContext9_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new flowchart_TypedDataContext9(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new flowchart_TypedDataContext9(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new flowchart_TypedDataContext9(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new flowchart_TypedDataContext9_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new flowchart_TypedDataContext9_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new flowchart_TypedDataContext9_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new flowchart_TypedDataContext9_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new flowchart_TypedDataContext9_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new flowchart_TypedDataContext9_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new flowchart_TypedDataContext10(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new flowchart_TypedDataContext10_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new flowchart_TypedDataContext10(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new flowchart_TypedDataContext10_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new flowchart_TypedDataContext10_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new flowchart_TypedDataContext10_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new flowchart_TypedDataContext10_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class flowchart_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class flowchart_TypedDataContext1 : flowchart_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string CorrDoc {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string CommentAll {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string Result {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
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
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 0)].Name != "CorrDoc") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "CommentAll") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Result") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "rejectionComments") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                return flowchart_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext1_ForReadOnly : flowchart_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string CorrDoc {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string CommentAll {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string Result {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
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
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 0)].Name != "CorrDoc") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "CommentAll") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Result") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "rejectionComments") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                return flowchart_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext2 : flowchart_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool isApprovedAtChecker;
            
            protected bool isApprovedAtMakerCentral;
            
            protected bool isFinallyApproved;
            
            protected bool isApprovedAtCheckerCentral;
            
            public flowchart_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string ProvidedDocument {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected string CorrectDocument {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
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
                this.isApprovedAtChecker = ((bool)(this.GetVariableValue((6 + locationsOffset))));
                this.isApprovedAtMakerCentral = ((bool)(this.GetVariableValue((7 + locationsOffset))));
                this.isFinallyApproved = ((bool)(this.GetVariableValue((8 + locationsOffset))));
                this.isApprovedAtCheckerCentral = ((bool)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((6 + locationsOffset), this.isApprovedAtChecker);
                this.SetVariableValue((7 + locationsOffset), this.isApprovedAtMakerCentral);
                this.SetVariableValue((8 + locationsOffset), this.isFinallyApproved);
                this.SetVariableValue((9 + locationsOffset), this.isApprovedAtCheckerCentral);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                if (((locationReferences[(offset + 4)].Name != "ProvidedDocument") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "CorrectDocument") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "isApprovedAtChecker") 
                            || (locationReferences[(offset + 6)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "isApprovedAtMakerCentral") 
                            || (locationReferences[(offset + 7)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "isFinallyApproved") 
                            || (locationReferences[(offset + 8)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "isApprovedAtCheckerCentral") 
                            || (locationReferences[(offset + 9)].Type != typeof(bool)))) {
                    return false;
                }
                return flowchart_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext2_ForReadOnly : flowchart_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool isApprovedAtChecker;
            
            protected bool isApprovedAtMakerCentral;
            
            protected bool isFinallyApproved;
            
            protected bool isApprovedAtCheckerCentral;
            
            public flowchart_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string ProvidedDocument {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected string CorrectDocument {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
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
                this.isApprovedAtChecker = ((bool)(this.GetVariableValue((6 + locationsOffset))));
                this.isApprovedAtMakerCentral = ((bool)(this.GetVariableValue((7 + locationsOffset))));
                this.isFinallyApproved = ((bool)(this.GetVariableValue((8 + locationsOffset))));
                this.isApprovedAtCheckerCentral = ((bool)(this.GetVariableValue((9 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                if (((locationReferences[(offset + 4)].Name != "ProvidedDocument") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "CorrectDocument") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "isApprovedAtChecker") 
                            || (locationReferences[(offset + 6)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "isApprovedAtMakerCentral") 
                            || (locationReferences[(offset + 7)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "isFinallyApproved") 
                            || (locationReferences[(offset + 8)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "isApprovedAtCheckerCentral") 
                            || (locationReferences[(offset + 9)].Type != typeof(bool)))) {
                    return false;
                }
                return flowchart_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext3 : flowchart_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 54 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  ProvidedDocument;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 54 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                  ProvidedDocument;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(string value) {
                
                #line 54 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                  ProvidedDocument = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 66 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  CommentAll;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 66 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                  CommentAll;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(string value) {
                
                #line 66 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                  CommentAll = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext3_ForReadOnly : flowchart_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 59 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  CommentAll;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr1Get() {
                
                #line 59 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                  CommentAll;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 71 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 71 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                  null;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 78 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                  !String.IsNullOrEmpty(CommentAll);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 78 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                  !String.IsNullOrEmpty(CommentAll);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 84 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    "Rejection Reason:" + CommentAll;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr5Get() {
                
                #line 84 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                    "Rejection Reason:" + CommentAll;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext4 : flowchart_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext4_ForReadOnly : flowchart_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext5 : flowchart_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool sendBackToMaker;
            
            public flowchart_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 152 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  isApprovedAtMakerCentral;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 152 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                  isApprovedAtMakerCentral;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(bool value) {
                
                #line 152 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                                  isApprovedAtMakerCentral = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 162 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  sendBackToMaker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 162 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                  sendBackToMaker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(bool value) {
                
                #line 162 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                                  sendBackToMaker = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 157 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  CommentAll;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 157 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                  CommentAll;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(string value) {
                
                #line 157 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                                  CommentAll = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.sendBackToMaker = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.sendBackToMaker);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                if (((locationReferences[(offset + 10)].Name != "sendBackToMaker") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                return flowchart_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext5_ForReadOnly : flowchart_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool sendBackToMaker;
            
            public flowchart_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 147 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  ProvidedDocument;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 147 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                  ProvidedDocument;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 169 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  !string.IsNullOrEmpty(CommentAll);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr10Get() {
                
                #line 169 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                  !string.IsNullOrEmpty(CommentAll);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 175 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    "Rejection Reason:"+ CommentAll;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr11Get() {
                
                #line 175 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                    "Rejection Reason:"+ CommentAll;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 185 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              !isApprovedAtMakerCentral && !sendBackToMaker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 185 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                              !isApprovedAtMakerCentral && !sendBackToMaker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 190 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              isApprovedAtMakerCentral && !sendBackToMaker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 190 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                              isApprovedAtMakerCentral && !sendBackToMaker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 337 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              !isApprovedAtMakerCentral && sendBackToMaker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 337 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                              !isApprovedAtMakerCentral && sendBackToMaker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            protected override void GetValueTypeValues() {
                this.sendBackToMaker = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                if (((locationReferences[(offset + 10)].Name != "sendBackToMaker") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                return flowchart_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext6 : flowchart_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext6_ForReadOnly : flowchart_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext7 : flowchart_TypedDataContext6 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool sendBackToChecker;
            
            public flowchart_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 204 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          isApprovedAtCheckerCentral;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr15Get() {
                
                #line 204 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                          isApprovedAtCheckerCentral;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(bool value) {
                
                #line 204 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                                          isApprovedAtCheckerCentral = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 214 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          sendBackToChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr17Get() {
                
                #line 214 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                          sendBackToChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(bool value) {
                
                #line 214 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                                          sendBackToChecker = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 209 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          CommentAll;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr18Get() {
                
                #line 209 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                          CommentAll;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(string value) {
                
                #line 209 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                                          CommentAll = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.sendBackToChecker = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.sendBackToChecker);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                if (((locationReferences[(offset + 10)].Name != "sendBackToChecker") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                return flowchart_TypedDataContext6.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext7_ForReadOnly : flowchart_TypedDataContext6_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool sendBackToChecker;
            
            public flowchart_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 199 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          ProvidedDocument;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 199 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                          ProvidedDocument;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 221 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                          !String.IsNullOrEmpty(CommentAll);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 221 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                          !String.IsNullOrEmpty(CommentAll);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 227 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                            "Rejection Reason" + CommentAll;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr20Get() {
                
                #line 227 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                            "Rejection Reason" + CommentAll;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 237 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      !isApprovedAtCheckerCentral && !sendBackToChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr21Get() {
                
                #line 237 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                      !isApprovedAtCheckerCentral && !sendBackToChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 242 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      !isApprovedAtCheckerCentral && sendBackToChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 242 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                      !isApprovedAtCheckerCentral && sendBackToChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 247 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                      isApprovedAtCheckerCentral && !sendBackToChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr23Get() {
                
                #line 247 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                      isApprovedAtCheckerCentral && !sendBackToChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            protected override void GetValueTypeValues() {
                this.sendBackToChecker = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 11))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 11);
                }
                expectedLocationsCount = 11;
                if (((locationReferences[(offset + 10)].Name != "sendBackToChecker") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                return flowchart_TypedDataContext6_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext8 : flowchart_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext8_ForReadOnly : flowchart_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext9 : flowchart_TypedDataContext8 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool sendBackToMaker;
            
            protected bool sendBackToChecker;
            
            public flowchart_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 261 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  isFinallyApproved;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr24Get() {
                
                #line 261 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                                  isFinallyApproved;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(bool value) {
                
                #line 261 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                                                  isFinallyApproved = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 271 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  sendBackToChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr26Get() {
                
                #line 271 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                                  sendBackToChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(bool value) {
                
                #line 271 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                                                  sendBackToChecker = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 276 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  sendBackToMaker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr27Get() {
                
                #line 276 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                                  sendBackToMaker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(bool value) {
                
                #line 276 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                                                  sendBackToMaker = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 266 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  CommentAll;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr28Get() {
                
                #line 266 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                                  CommentAll;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(string value) {
                
                #line 266 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                                                  CommentAll = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.sendBackToMaker = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                this.sendBackToChecker = ((bool)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.sendBackToMaker);
                this.SetVariableValue((11 + locationsOffset), this.sendBackToChecker);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 10)].Name != "sendBackToMaker") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "sendBackToChecker") 
                            || (locationReferences[(offset + 11)].Type != typeof(bool)))) {
                    return false;
                }
                return flowchart_TypedDataContext8.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext9_ForReadOnly : flowchart_TypedDataContext8_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool sendBackToMaker;
            
            protected bool sendBackToChecker;
            
            public flowchart_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 256 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  ProvidedDocument;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr25Get() {
                
                #line 256 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                                  ProvidedDocument;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 283 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                                  !String.IsNullOrEmpty(CommentAll);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr29Get() {
                
                #line 283 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                                  !String.IsNullOrEmpty(CommentAll);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 289 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                    "Rejection Reason:" + CommentAll;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 289 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                                    "Rejection Reason:" + CommentAll;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 299 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              !isFinallyApproved && !sendBackToMaker && !sendBackToChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr31Get() {
                
                #line 299 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                              !isFinallyApproved && !sendBackToMaker && !sendBackToChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 304 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              !isFinallyApproved && !sendBackToMaker && sendBackToChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr32Get() {
                
                #line 304 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                              !isFinallyApproved && !sendBackToMaker && sendBackToChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 309 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              isFinallyApproved && !sendBackToMaker && !sendBackToChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr33Get() {
                
                #line 309 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                              isFinallyApproved && !sendBackToMaker && !sendBackToChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 317 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              !isFinallyApproved && sendBackToMaker && !sendBackToChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr34Get() {
                
                #line 317 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                                              !isFinallyApproved && sendBackToMaker && !sendBackToChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            protected override void GetValueTypeValues() {
                this.sendBackToMaker = ((bool)(this.GetVariableValue((10 + locationsOffset))));
                this.sendBackToChecker = ((bool)(this.GetVariableValue((11 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 12))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 12);
                }
                expectedLocationsCount = 12;
                if (((locationReferences[(offset + 10)].Name != "sendBackToMaker") 
                            || (locationReferences[(offset + 10)].Type != typeof(bool)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "sendBackToChecker") 
                            || (locationReferences[(offset + 11)].Type != typeof(bool)))) {
                    return false;
                }
                return flowchart_TypedDataContext8_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext10 : flowchart_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext10(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext10(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 105 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          isApprovedAtChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr35Get() {
                
                #line 105 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                          isApprovedAtChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(bool value) {
                
                #line 105 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                          isApprovedAtChecker = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 110 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          CommentAll;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr37Get() {
                
                #line 110 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                          CommentAll;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr37Set(string value) {
                
                #line 110 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                
                          CommentAll = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr37Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr37Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext10_ForReadOnly : flowchart_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext10_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 100 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          ProvidedDocument;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr36Get() {
                
                #line 100 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                          ProvidedDocument;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 117 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          !String.IsNullOrEmpty(CommentAll);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr38Get() {
                
                #line 117 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                          !String.IsNullOrEmpty(CommentAll);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 123 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            "Rejection Reason:" + CommentAll;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr39Get() {
                
                #line 123 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                            "Rejection Reason:" + CommentAll;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 133 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      !isApprovedAtChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr40Get() {
                
                #line 133 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                      !isApprovedAtChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 138 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      isApprovedAtChecker;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr41Get() {
                
                #line 138 "C:\USERS\NOUMAN.ALI\DESKTOP\WORKFLOW\WORKFLOW\COMPLAINTMANAGEMENTSYSTEM_WORKFLOW\FLOWCHART.XAML"
                return 
                      isApprovedAtChecker;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext11 : flowchart_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext11(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext11(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class flowchart_TypedDataContext11_ForReadOnly : flowchart_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public flowchart_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public flowchart_TypedDataContext11_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 10))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 10);
                }
                expectedLocationsCount = 10;
                return flowchart_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
