﻿namespace AndOS.Shared.Requests.UserPreferences.Get.GetDefaultProgramByExtension;

public record GetDefaultProgramByExtensionRequest(string Extension) : IRequest<GetDefaultProgramByExtensionResponse>;