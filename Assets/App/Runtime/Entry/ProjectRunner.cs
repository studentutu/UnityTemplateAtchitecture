using System.Collections;
using System.Collections.Generic;
using App.Runtime.MVC.Example1;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

public class ProjectRunner : MonoBehaviour
{
	private void Awake()
	{
		var instance = ProjectContext.Instance;
		var container = instance.Container;

		ReactiveClickerInstaller.Install(container);
	}

	private void OnEnable()
	{
		var runner = ProjectContext.Instance.Container.Resolve<ReactiveCLickerRunner>();
		runner.RunFullViewWithController().Forget();
	}
}