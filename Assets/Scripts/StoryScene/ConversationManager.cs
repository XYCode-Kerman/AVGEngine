using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    public Image backgroundImage;
    public Image characterImage;
    public TextMeshProUGUI speaker;
    public TextMeshProUGUI content;

    private ADF adf;
    private int sectionId = 0;
    private int conversationId = 0;
    private Section section;
    private Conversation conversation;

    void LoadADF()
    {
        adf = GameObject.Find("GameManager").GetComponent<ADFParser>().adf;

        section = adf.sections[sectionId];
        conversation = section.conversations[conversationId];
    }

    void Start()
    {
        LoadADF();

        UpdateImages();
        UpdateConversation();
    }

    void UpdateImages()
    {
        backgroundImage.sprite = conversation.GetBackgroundImage();
        characterImage.sprite = conversation.GetSpeakerImage();
    }

    void UpdateConversation()
    {
        speaker.text = conversation.speaker;
        content.text = conversation.content;
    }

    public void NextConversation()
    {
        if (conversationId < section.conversations.Length - 1)
        {
            conversationId++;
            conversation = section.conversations[conversationId];
            UpdateImages();
        }
        else if (conversationId == section.conversations.Length - 1) // 最后一段对话
        {
            if (sectionId < adf.sections.Length - 1) // 还有下一章节
            {
                sectionId++;
                section = adf.sections[sectionId];
                conversationId = 0; // 重置对话ID
                conversation = section.conversations[conversationId]; // 获取新章节的第一段对话
                UpdateImages(); // 更新背景图
                UpdateConversation(); // 更新对话内容
            }
            else // 没有下一章节了，结束故事
            {
                // TODO: 结束故事逻辑，例如显示结束界面或跳转到其他场景等。
                Debug.Log("Story finished.");
            }
        }
    }
}
