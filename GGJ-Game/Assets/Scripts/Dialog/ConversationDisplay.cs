using UnityEngine;

public class ConversationDisplay : MonoBehaviour
{
    public Conversation conversation;

    public GameObject speakerLeft;
    public GameObject speakerRight;

    private SpeakerUIs speakerUILeft;
    private SpeakerUIs speakerUIRight;

    private int activeLineIndex;
    private bool conversationStarted = false;

    void Start()
    {
        speakerUILeft = speakerLeft.GetComponent<SpeakerUIs>();
        speakerUIRight = speakerRight.GetComponent<SpeakerUIs>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("return")) {
          AdvanceConversation();
        }
    }

    private void EndConversation() {
      conversation = null;
      conversationStarted = false;
      speakerUILeft.Hide();
      speakerUIRight.Hide();
    }

    public void StartDialogue (Conversation conversation) {
      Initialize();
    }

    private void Initialize() {
      conversationStarted = true;
      activeLineIndex = 0;
      speakerUILeft.Speaker = conversation.speakerLeft;
      speakerUIRight.Speaker = conversation.speakerRight;
    }


    private void AdvanceLine() {
      if (conversation == null) return;
      if(!conversationStarted) Initialize();

      if(activeLineIndex < conversation.lines.Length)
        DisplayLine();
        else
        EndConversation();
    }

    private void AdvanceConversation() {
      if (activeLineIndex < conversation.lines.Length) {
        DisplayLine();
        activeLineIndex += 1;
      } else {
        speakerUILeft.Hide();
        speakerUIRight.Hide();
        activeLineIndex = 0;
      }
    }

    private void DisplayLine() {
      Line line = conversation.lines[activeLineIndex];
      Character character = line.character;

      if(speakerUILeft.SpeakerIs(character)) {
        SetDialog(speakerUILeft, speakerUIRight, line.text);
      } else {
        SetDialog(speakerUIRight, speakerUILeft, line.text);
      }
      activeLineIndex += 1;
    }

    private void SetDialog(
      SpeakerUIs activeSpeakerUI,
      SpeakerUIs inactiveSpeakerUI,
      string text) {
        activeSpeakerUI.Dialog = text;
        activeSpeakerUI.Show();
        inactiveSpeakerUI.Hide();
    }
}
