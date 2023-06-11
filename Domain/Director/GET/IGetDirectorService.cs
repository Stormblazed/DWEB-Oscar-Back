﻿using Domain.Director.GET.Entities;

namespace Domain.Director.GET;
public interface IGetDirectorService
{
    public  Task<List<GetDirectorResponse>> GetDirectorResponse(GetDirectorRequest request);

}
