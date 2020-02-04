/*
 * Copyright 2020 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using IonDotnet.Tree;
using IonDotnet.Tree.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IonDotnet.Tests.Tree
{
    [TestClass]
    public class IonListTest : IonSequenceTest
    {
        protected override IIonValue MakeMutableValue()
        {
            return new IonList();
        }

        internal override IonContainer MakeNullValue()
        {
            return IonList.NewNull();
        }

        internal override void DoAdd(IonContainer container, IonValue item)
        {
            var list = (IonList) container;
            list.Add(item);
        }
    }
}
