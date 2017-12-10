//uScript Generated Code - Build 1.0.3077
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("BallController", "")]
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
   UnityEngine.Vector2 local_startDirection_UnityEngine_Vector2 = new Vector2( (float)0, (float)0 );
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_0 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetRigidBody2D logic_uScriptAct_GetRigidBody2D_uScriptAct_GetRigidBody2D_1 = new uScriptAct_GetRigidBody2D( );
   UnityEngine.GameObject logic_uScriptAct_GetRigidBody2D_Target_1 = default(UnityEngine.GameObject);
   UnityEngine.Rigidbody2D logic_uScriptAct_GetRigidBody2D_rigidBody_1;
   bool logic_uScriptAct_GetRigidBody2D_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_SetRandomVector2 logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_6 = new uScriptAct_SetRandomVector2( );
   System.Single logic_uScriptAct_SetRandomVector2_MinX_6 = (float) -1;
   System.Single logic_uScriptAct_SetRandomVector2_MaxX_6 = (float) 1;
   System.Single logic_uScriptAct_SetRandomVector2_MinY_6 = (float) -1;
   System.Single logic_uScriptAct_SetRandomVector2_MaxY_6 = (float) 1;
   UnityEngine.Vector2 logic_uScriptAct_SetRandomVector2_TargetVector2_6;
   bool logic_uScriptAct_SetRandomVector2_Out_6 = true;
   
   //event nodes
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_0 || false == m_RegisteredForEvents )
      {
         owner_Connection_0 = parentGameObject;
         if ( null != owner_Connection_0 )
         {
            {
               uScript_GameObject component = owner_Connection_0.GetComponent<uScript_GameObject>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_GameObject>();
               }
               if ( null != component )
               {
                  component.EnableEvent += Instance_EnableEvent_3;
                  component.DisableEvent += Instance_DisableEvent_3;
                  component.DestroyEvent += Instance_DestroyEvent_3;
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
         if ( null != owner_Connection_0 )
         {
            {
               uScript_GameObject component = owner_Connection_0.GetComponent<uScript_GameObject>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_GameObject>();
               }
               if ( null != component )
               {
                  component.EnableEvent += Instance_EnableEvent_3;
                  component.DisableEvent += Instance_DisableEvent_3;
                  component.DestroyEvent += Instance_DestroyEvent_3;
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
      if ( null != owner_Connection_0 )
      {
         {
            uScript_GameObject component = owner_Connection_0.GetComponent<uScript_GameObject>();
            if ( null != component )
            {
               component.EnableEvent -= Instance_EnableEvent_3;
               component.DisableEvent -= Instance_DisableEvent_3;
               component.DestroyEvent -= Instance_DestroyEvent_3;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetRigidBody2D_uScriptAct_GetRigidBody2D_1.SetParent(g);
      logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_6.SetParent(g);
      owner_Connection_0 = parentGameObject;
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
   
   void Instance_EnableEvent_3(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_EnableEvent_3( );
   }
   
   void Instance_DisableEvent_3(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_DisableEvent_3( );
   }
   
   void Instance_DestroyEvent_3(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_DestroyEvent_3( );
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0a594382-7e42-4f18-8491-6d1cb6ad9859", "Get_Rigidbody__2D_", Relay_In_1)) return; 
         {
            {
               logic_uScriptAct_GetRigidBody2D_Target_1 = owner_Connection_0;
               
            }
            {
            }
         }
         logic_uScriptAct_GetRigidBody2D_uScriptAct_GetRigidBody2D_1.In(logic_uScriptAct_GetRigidBody2D_Target_1, out logic_uScriptAct_GetRigidBody2D_rigidBody_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript BallController.uscript at Get Rigidbody (2D).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_EnableEvent_3()
   {
      if (true == CheckDebugBreak("fb967b9f-4dee-4a64-8ab8-fc51f74ce4bb", "GameObject_Events", Relay_EnableEvent_3)) return; 
      Relay_In_6();
   }
   
   void Relay_DisableEvent_3()
   {
      if (true == CheckDebugBreak("fb967b9f-4dee-4a64-8ab8-fc51f74ce4bb", "GameObject_Events", Relay_DisableEvent_3)) return; 
   }
   
   void Relay_DestroyEvent_3()
   {
      if (true == CheckDebugBreak("fb967b9f-4dee-4a64-8ab8-fc51f74ce4bb", "GameObject_Events", Relay_DestroyEvent_3)) return; 
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7465deee-772e-4035-a70a-2df6f0f77698", "Set_Random_Vector2", Relay_In_6)) return; 
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
         logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_6.In(logic_uScriptAct_SetRandomVector2_MinX_6, logic_uScriptAct_SetRandomVector2_MaxX_6, logic_uScriptAct_SetRandomVector2_MinY_6, logic_uScriptAct_SetRandomVector2_MaxY_6, out logic_uScriptAct_SetRandomVector2_TargetVector2_6);
         local_startDirection_UnityEngine_Vector2 = logic_uScriptAct_SetRandomVector2_TargetVector2_6;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_6.Out;
         
         if ( test_0 == true )
         {
            Relay_In_1();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript BallController.uscript at Set Random Vector2.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "BallController.uscript:startDirection", local_startDirection_UnityEngine_Vector2);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f2f14c62-4738-4adb-9e24-db54a3469dfb", local_startDirection_UnityEngine_Vector2);
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
