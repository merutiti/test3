using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���؂�ւ��ɕK�v

// �^�b�`����ƁA�V�[����؂芷����
public class Rescene : MonoBehaviour
{
	public void PushButton()
	{ // �^�b�`������
			Time.timeScale = 1;//�Q�[���I�[�o�[����Ȃ���
	  // ���݂�Scene���擾
		Scene loadScene = SceneManager.GetActiveScene();
		// ���݂̃V�[�����ēǂݍ��݂���
		SceneManager.LoadScene(loadScene.name);
	}
}
