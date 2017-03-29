﻿using UnityEngine;

namespace Entitas.CodeGenerator.Unity.Editor {

    public class DebugLogPostProcessor : ICodeGenFilePostProcessor {

        public string name { get { return "Debug.Log generated files"; } }
        public bool isEnabledByDefault { get { return false; } }
        public int priority { get { return 200; } }
        public bool runInDryMode { get { return true; } }

        public CodeGenFile[] PostProcess(CodeGenFile[] files) {
            foreach(var file in files) {
                Debug.Log(file.generatorName + ": " + file.fileName);
            }

            return files;
        }
    }
}
