using FluentValidation;
using System;

namespace ReviewManagement.App.Extension
{
	public static class ValidatorExtension
    {
        public static IRuleBuilderOptions<T, string> ValidateUrl<T>(this IRuleBuilder<T, string> builder)
        {
            return builder
                .Must(url => Uri.IsWellFormedUriString(url, UriKind.Absolute))
                .WithMessage("Invalid url of image");
        }
    }
}
