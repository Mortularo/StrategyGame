<<<<<<< Updated upstream:Assets/_Root/Scripts/Utils/AssetInjector/AssetsInjector.cs
﻿using System;
using System.Reflection;

=======
using System;
using System.Reflection;
>>>>>>> Stashed changes:Assets/_Root/Scripts/Utils/AssetsInjector/AssetsInjector.cs
public static class AssetsInjector
{
    private static readonly Type _injectAssetAttributeType = typeof(InjectAssetAttribute);
    public static T Inject<T>(this AssetsContext context, T target)
    {
        var targetType = target.GetType();
        while (targetType != null)
        {
            var allFields = targetType.GetFields(BindingFlags.NonPublic |
            BindingFlags.Public | BindingFlags.Instance);
            for (int i = 0; i < allFields.Length; i++)
            {
                var fieldInfo = allFields[i];
                var injectAssetAttribute =
                fieldInfo.GetCustomAttribute(_injectAssetAttributeType) as InjectAssetAttribute;
                if (injectAssetAttribute == null)
                {
                    continue;
                }
                var objectToInject = context.GetObjectOfType(fieldInfo.FieldType,
<<<<<<< Updated upstream:Assets/_Root/Scripts/Utils/AssetInjector/AssetsInjector.cs
                    injectAssetAttribute.AssetName);
=======
                injectAssetAttribute.AssetName);
>>>>>>> Stashed changes:Assets/_Root/Scripts/Utils/AssetsInjector/AssetsInjector.cs
                fieldInfo.SetValue(target, objectToInject);
            }
            targetType = targetType.BaseType;
        }
        return target;
    }
<<<<<<< Updated upstream:Assets/_Root/Scripts/Utils/AssetInjector/AssetsInjector.cs
}
=======
}
>>>>>>> Stashed changes:Assets/_Root/Scripts/Utils/AssetsInjector/AssetsInjector.cs
