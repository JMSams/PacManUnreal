//uScript Generated Code - Build 1.0.3085
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class BallController : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public System.Single forceScale = (float) 1;
   UnityEngine.Vector2 local_5_UnityEngine_Vector2 = new Vector2( (float)0, (float)0 );
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_AddForce2D logic_uScriptAct_AddForce2D_uScriptAct_AddForce2D_2 = new uScriptAct_AddForce2D( );
   UnityEngine.GameObject logic_uScriptAct_AddForce2D_Target_2 = default(UnityEngine.GameObject);
   UnityEngine.Vector2 logic_uScriptAct_AddForce2D_force_2 = new Vector2( );
   System.Single logic_uScriptAct_AddForce2D_scale_2 = (float) 0;
   bool logic_uScriptAct_AddForce2D_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_SetRandomVector2 logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_4 = new uScriptAct_SetRandomVector2( );
   System.Single logic_uScriptAct_SetRandomVector2_MinX_4 = (float) -100;
   System.Single logic_uScriptAct_SetRandomVector2_MaxX_4 = (float) 100;
   System.Single logic_uScriptAct_SetRandomVector2_MinY_4 = (float) -100;
   System.Single logic_uScriptAct_SetRandomVector2_MaxY_4 = (float) 100;
   UnityEngine.Vector2 logic_uScriptAct_SetRandomVector2_TargetVector2_4;
   bool logic_uScriptAct_SetRandomVector2_Out_4 = true;
   
   //event nodes
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_1 || false == m_RegisteredForEvents )
      {
         owner_Connection_1 = parentGameObject;
         if ( null != owner_Connection_1 )
         {
            {
               uScript_Global component = owner_Connection_1.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_0;
                  component.uScriptLateStart += Instance_uScriptLateStart_0;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_1 )
         {
            {
               uScript_Global component = owner_Connection_1.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_0;
                  component.uScriptLateStart += Instance_uScriptLateStart_0;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_1 )
      {
         {
            uScript_Global component = owner_Connection_1.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_0;
               component.uScriptLateStart -= Instance_uScriptLateStart_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_AddForce2D_uScriptAct_AddForce2D_2.SetParent(g);
      logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_4.SetParent(g);
      owner_Connection_1 = parentGameObject;
   }
   public void Awake()
   {
      
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_uScriptStart_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_0( );
   }
   
   void Instance_uScriptLateStart_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_0( );
   }
   
   void Relay_uScriptStart_0()
   {
      if (true == CheckDebugBreak("45086bfe-b089-48fc-9c17-001a13e323d1", "uScript_Events", Relay_uScriptStart_0)) return; 
      Relay_In_4();
   }
   
   void Relay_uScriptLateStart_0()
   {
      if (true == CheckDebugBreak("45086bfe-b089-48fc-9c17-001a13e323d1", "uScript_Events", Relay_uScriptLateStart_0)) return; 
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b344649c-6f17-4173-9de4-2dc5e8a0f7e3", "Add_Force__2D_", Relay_In_2)) return; 
         {
            {
               logic_uScriptAct_AddForce2D_Target_2 = owner_Connection_1;
               
            }
            {
               logic_uScriptAct_AddForce2D_force_2 = local_5_UnityEngine_Vector2;
               
            }
            {
               logic_uScriptAct_AddForce2D_scale_2 = forceScale;
               
            }
         }
         logic_uScriptAct_AddForce2D_uScriptAct_AddForce2D_2.In(logic_uScriptAct_AddForce2D_Target_2, logic_uScriptAct_AddForce2D_force_2, logic_uScriptAct_AddForce2D_scale_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript BallController.uscript at Add Force (2D).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("478f6ac2-977f-4783-aa6a-7000a253f12d", "Set_Random_Vector2", Relay_In_4)) return; 
         {
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_4.In(logic_uScriptAct_SetRandomVector2_MinX_4, logic_uScriptAct_SetRandomVector2_MaxX_4, logic_uScriptAct_SetRandomVector2_MinY_4, logic_uScriptAct_SetRandomVector2_MaxY_4, out logic_uScriptAct_SetRandomVector2_TargetVector2_4);
         local_5_UnityEngine_Vector2 = logic_uScriptAct_SetRandomVector2_TargetVector2_4;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_4.Out;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript BallController.uscript at Set Random Vector2.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "BallController.uscript:forceScale", forceScale);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "c9a1abc9-925f-41ff-b76c-b45921d6f361", forceScale);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "BallController.uscript:5", local_5_UnityEngine_Vector2);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "9d1756e6-53d8-43b9-b7ac-ed8b70fd6c62", local_5_UnityEngine_Vector2);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
