using System;
using UnityEngine;

public class SendMessageToEntityOnAnimationFinish : StateMachineBehaviour
{
	public string messageToSendToEntity;

	public float repeatRate = 0.1f;

	private const float lastMessageSent = 0f;

	public SendMessageToEntityOnAnimationFinish()
	{
	}

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		if (0f + this.repeatRate > Time.time)
		{
			return;
		}
		if (animator.IsInTransition(layerIndex))
		{
			return;
		}
		if (stateInfo.normalizedTime < 1f)
		{
			return;
		}
		for (int i = 0; i < animator.layerCount; i++)
		{
			if (i != layerIndex)
			{
				if (animator.IsInTransition(i))
				{
					return;
				}
				AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(i);
				if (currentAnimatorStateInfo.speed > 0f && currentAnimatorStateInfo.normalizedTime < 1f)
				{
					return;
				}
			}
		}
		BaseEntity baseEntity = animator.gameObject.ToBaseEntity();
		if (baseEntity)
		{
			baseEntity.SendMessage(this.messageToSendToEntity);
		}
	}
}