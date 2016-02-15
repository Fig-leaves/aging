using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateStage : MonoBehaviour {
	const int StageTipSize = 17;

	int currentTipIndex;

	public Transform player;
	public GameObject[] stageTips;
	public int startTipIndex;
	public int preInstantiate;

	public List<GameObject> createdStageList = new List<GameObject>();


	// Use this for initialization
	void Start ()
	{
		currentTipIndex = startTipIndex -1;
		UpdateStage(preInstantiate);
	}

	// Update is called once per frame
	void Update ()
	{
		int charaPositionIndex = (int)(player.position.x / StageTipSize);

		// 次のステージチップにはいったらステージの更新処理をする
		if (charaPositionIndex + preInstantiate > currentTipIndex)
		{
			UpdateStage(charaPositionIndex + preInstantiate);
		}
	}

	// 指定のIndexまでのステージチップを生成して管理下に置く
	void UpdateStage (int toTipIndex)
	{
		if (toTipIndex <= currentTipIndex) return;

		// 指定のステージチップまでを生成
		for (int i = currentTipIndex +1; i <= toTipIndex; i++)
		{
			GameObject stageObject = StageCreater(i);

			//　生成したステージチップを管理リストに追加
			createdStageList.Add(stageObject);
		}
		// ステージ保持上限になるまで古いステージを削除
			while (createdStageList.Count > preInstantiate + 2) DestroyOldStage();

		currentTipIndex = toTipIndex;
	}

	// 指定のインデックス位置にStageオブジェクトをランダムに生成
	GameObject StageCreater (int tipIndex)
	{
		int nextStageTip = Random.Range(0, stageTips.Length);

		GameObject stageObject = (GameObject)Instantiate(
			stageTips[nextStageTip],
			new Vector3(tipIndex * StageTipSize,0,0),
			Quaternion.identity
			);

		return stageObject;
	}

	void DestroyOldStage () {
		if (currentTipIndex > 3) {
			GameObject oldStage = createdStageList[1];
			Destroy(oldStage);

		}
	}

}
