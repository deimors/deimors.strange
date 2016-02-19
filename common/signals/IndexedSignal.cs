using strange.extensions.signal.impl;
using System;
using System.Collections.Generic;
using UnityEngine.Assertions;

namespace deimors.strange.common.signals {
    public class IndexedSignal<TIndex> : Signal<TIndex> {
        private Dictionary<TIndex, Action> listenerMap = new Dictionary<TIndex, Action>();

        public void AddListener(TIndex index, Action listener) {
            if (!listenerMap.ContainsKey(index)) {
                listenerMap.Add(index, delegate { });
            }

            listenerMap[index] += listener;
        }

        public void RemoveListener(TIndex index, Action listener) {
            Assert.IsTrue(listenerMap.ContainsKey(index));

            listenerMap[index] -= listener;
        }

        public override void Dispatch(TIndex index) {
            Assert.IsTrue(listenerMap.ContainsKey(index));

            listenerMap[index]();

            base.Dispatch(index);
        }
    }

    public class IndexedSignal<TIndex, TParam1> : Signal<TIndex, TParam1> {
        private Dictionary<TIndex, Action<TParam1>> listenerMap = new Dictionary<TIndex, Action<TParam1>>();

        public void AddListener(TIndex index, Action<TParam1> listener) {
            if (!listenerMap.ContainsKey(index)) {
                listenerMap.Add(index, delegate { });
            }

            listenerMap[index] += listener;
        }

        public void RemoveListener(TIndex index, Action<TParam1> listener) {
            Assert.IsTrue(listenerMap.ContainsKey(index));

            listenerMap[index] -= listener;
        }

        public override void Dispatch(TIndex index, TParam1 param1) {
            Assert.IsTrue(listenerMap.ContainsKey(index));

            listenerMap[index](param1);

            base.Dispatch(index, param1);
        }
    }

    public class IndexedSignal<TIndex, TParam1, TParam2> : Signal<TIndex, TParam1, TParam2> {
        private Dictionary<TIndex, Action<TParam1, TParam2>> listenerMap = new Dictionary<TIndex, Action<TParam1, TParam2>>();

        public void AddListener(TIndex index, Action<TParam1, TParam2> listener) {
            if (!listenerMap.ContainsKey(index)) {
                listenerMap.Add(index, delegate { });
            }

            listenerMap[index] += listener;
        }

        public void RemoveListener(TIndex index, Action<TParam1, TParam2> listener) {
            Assert.IsTrue(listenerMap.ContainsKey(index));

            listenerMap[index] -= listener;
        }

        public override void Dispatch(TIndex index, TParam1 param1, TParam2 param2) {
            Assert.IsTrue(listenerMap.ContainsKey(index));

            listenerMap[index](param1, param2);

            base.Dispatch(index, param1, param2);
        }
    }

    public class IndexedSignal<TIndex, TParam1, TParam2, TParam3> : Signal<TIndex, TParam1, TParam2, TParam3> {
        private Dictionary<TIndex, Action<TParam1, TParam2, TParam3>> listenerMap = new Dictionary<TIndex, Action<TParam1, TParam2, TParam3>>();

        public void AddListener(TIndex index, Action<TParam1, TParam2, TParam3> listener) {
            if (!listenerMap.ContainsKey(index)) {
                listenerMap.Add(index, delegate { });
            }

            listenerMap[index] += listener;
        }

        public void RemoveListener(TIndex index, Action<TParam1, TParam2, TParam3> listener) {
            Assert.IsTrue(listenerMap.ContainsKey(index));

            listenerMap[index] -= listener;
        }

        public override void Dispatch(TIndex index, TParam1 param1, TParam2 param2, TParam3 param3) {
            Assert.IsTrue(listenerMap.ContainsKey(index));

            listenerMap[index](param1, param2, param3);

            base.Dispatch(index, param1, param2, param3);
        }
    }
}
