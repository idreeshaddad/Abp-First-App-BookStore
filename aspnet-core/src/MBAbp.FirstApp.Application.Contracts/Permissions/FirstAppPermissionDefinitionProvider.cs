﻿using MBAbp.FirstApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MBAbp.FirstApp.Permissions;

public class FirstAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var FirstAppGroup = context.AddGroup(FirstAppPermissions.GroupName, L("Permission:BookStore"));
        var booksPermission = FirstAppGroup.AddPermission(FirstAppPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(FirstAppPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(FirstAppPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(FirstAppPermissions.Books.Delete, L("Permission:Books.Delete"));


    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FirstAppResource>(name);
    }
}
