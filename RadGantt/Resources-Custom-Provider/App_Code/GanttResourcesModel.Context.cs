﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class GanttResourcesEntities : DbContext
{
    public GanttResourcesEntities()
        : base("name=GanttResourcesEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public DbSet<GanttDependency> GanttDependencies { get; set; }
    public DbSet<GanttResourceAssignment> GanttResourceAssignments { get; set; }
    public DbSet<GanttResource> GanttResources { get; set; }
    public DbSet<GanttTask> GanttTasks { get; set; }
}