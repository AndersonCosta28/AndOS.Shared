﻿namespace AndOS.Shared.Requests.UserPreferences.Update;
public record UpdateDefaultProgramsToExtensionRequest(List<DefaultProgramToExtensionDTO> DefaultProgramsToExtensions) : IRequest;