//uScript Generated Code - Build 1.0.3085
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Test : uScriptLogic
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
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_PrintList logic_uScriptAct_PrintList_uScriptAct_PrintList_2 = new uScriptAct_PrintList( );
   System.String[] logic_uScriptAct_PrintList_Strings_2 = new System.String[] {"Enabled"};
   bool logic_uScriptAct_PrintList_Out_2 = true;
   
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
               uScript_GameObject component = owner_Connection_1.GetComponent<uScript_GameObject>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_GameObject>();
               }
               if ( null != component )
               {
                  component.EnableEvent += Instance_EnableEvent_0;
                  component.DisableEvent += Instance_DisableEvent_0;
                  component.DestroyEvent += Instance_DestroyEvent_0;
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
               uScript_GameObject component = owner_Connection_1.GetComponent<uScript_GameObject>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_GameObject>();
               }
               if ( null != component )
               {
                  component.EnableEvent += Instance_EnableEvent_0;
                  component.DisableEvent += Instance_DisableEvent_0;
                  component.DestroyEvent += Instance_DestroyEvent_0;
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
            uScript_GameObject component = owner_Connection_1.GetComponent<uScript_GameObject>();
            if ( null != component )
            {
               component.EnableEvent -= Instance_EnableEvent_0;
               component.DisableEvent -= Instance_DisableEvent_0;
               component.DestroyEvent -= Instance_DestroyEvent_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_PrintList_uScriptAct_PrintList_2.SetParent(g);
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
   
   void Instance_EnableEvent_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_EnableEvent_0( );
   }
   
   void Instance_DisableEvent_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_DisableEvent_0( );
   }
   
   void Instance_DestroyEvent_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_DestroyEvent_0( );
   }
   
   void Relay_EnableEvent_0()
   {
      if (true == CheckDebugBreak("a9aaf7f4-b135-4b8c-b62f-df9088132cfe", "GameObject_Events", Relay_EnableEvent_0)) return; 
      Relay_In_2();
   }
   
   void Relay_DisableEvent_0()
   {
      if (true == CheckDebugBreak("a9aaf7f4-b135-4b8c-b62f-df9088132cfe", "GameObject_Events", Relay_DisableEvent_0)) return; 
   }
   
   void Relay_DestroyEvent_0()
   {
      if (true == CheckDebugBreak("a9aaf7f4-b135-4b8c-b62f-df9088132cfe", "GameObject_Events", Relay_DestroyEvent_0)) return; 
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("50b051af-d5f5-46c5-8d6a-b7ce0a8de696", "Print_String_List", Relay_In_2)) return; 
         {
            {
            }
         }
         logic_uScriptAct_PrintList_uScriptAct_PrintList_2.In(logic_uScriptAct_PrintList_Strings_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Test.uscript at Print String List.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
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
