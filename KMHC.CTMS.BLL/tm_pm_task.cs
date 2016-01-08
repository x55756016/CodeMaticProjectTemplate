/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2015-12-02                                         创建 
 *  
 */
 
using Project.Common.Helper;
using Project.DAL;
using Project.DAL.Database;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Project.BLL
{
    public class tm_pm_taskBLL
    {
        protected static tm_pm_taskDAL dal = new tm_pm_taskDAL();

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_tm_pm_task model)
        {
             if (model == null)
                return string.Empty;
            tm_pm_task entity = ModelToEntity(model);
            entity.TASKID = string.IsNullOrEmpty(model.TASKID) ? Guid.NewGuid().ToString("N") : model.TASKID;

            return dal.Add(entity);
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_tm_pm_task Get(Expression<Func<tm_pm_task, bool>> predicate = null)
        {
            tm_pm_task entity= dal.Get(predicate);
            return EntityToModel(entity); 
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_tm_pm_task> Get()
        {
            List<tm_pm_task> entitys = dal.Get().ToList();
            List<V_tm_pm_task> list = new List<V_tm_pm_task>();
            foreach (tm_pm_task item in entitys)
            {
                list.Add(EntityToModel(item));
            }
            return list;
        }
        
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public IEnumerable<V_tm_pm_task> GetList(PageInfo page)
        {
            var list = dal.Get();

            return list.Paging(ref page).Select(EntityToModel).ToList();
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_tm_pm_task model)
        {
            if (model == null) return false;
            tm_pm_task entitys = ModelToEntity(model);
            
            return dal.Edit(entitys);
        }
        
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;

            return dal.Delete(id);
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private tm_pm_task ModelToEntity(V_tm_pm_task model)
        {
            if (model != null)
            {
                tm_pm_task entity = new tm_pm_task()
                {
                	                    	TASKID = model.TASKID,
                                        	PROJECTID = model.PROJECTID,
                                        	PRETASKID = model.PRETASKID,
                                        	FATHERTASKID = model.FATHERTASKID,
                                        	ORDERNUMBER = model.ORDERNUMBER,
                                        	TASKNAME = model.TASKNAME,
                                        	COSTTIME = model.COSTTIME,
                                        	STARTDATE = model.STARTDATE,
                                        	ENDDATE = model.ENDDATE,
                                        	USERNAME = model.USERNAME,
                                        	PROGRESS = model.PROGRESS,
                                        	TASKREMARK = model.TASKREMARK,
                                        	OWENRID = model.OWENRID,
                                        	OWNERPOSTID = model.OWNERPOSTID,
                                        	OWNERDEPARTMENTID = model.OWNERDEPARTMENTID,
                                        	OWNERCOMPANYID = model.OWNERCOMPANYID,
                                        	CREATETIME = model.CREATETIME,
                                        	CREATEUSER = model.CREATEUSER,
                                        	EDITTIME = model.EDITTIME,
                                        	EDITUSER = model.EDITUSER,
                                        	PMANAGER = model.PMANAGER,
                                        	ISCOMFIRM = model.ISCOMFIRM,
                                        	REALFINISHDATE = model.REALFINISHDATE,
                                        	RESULTSCORE = model.RESULTSCORE,
                                        	SUGGESTIONS = model.SUGGESTIONS,
                                    };

                return entity;
            }
            return null;
        }

        /// <summary>
        /// Entity转Model
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private V_tm_pm_task  EntityToModel(tm_pm_task  entity)
        {
            if (entity != null)
            {
                V_tm_pm_task  model = new V_tm_pm_task ()
                {
                                       	TASKID = entity.TASKID,
                                        	PROJECTID = entity.PROJECTID,
                                        	PRETASKID = entity.PRETASKID,
                                        	FATHERTASKID = entity.FATHERTASKID,
                                        	ORDERNUMBER = entity.ORDERNUMBER,
                                        	TASKNAME = entity.TASKNAME,
                                        	COSTTIME = entity.COSTTIME,
                                        	STARTDATE = entity.STARTDATE,
                                        	ENDDATE = entity.ENDDATE,
                                        	USERNAME = entity.USERNAME,
                                        	PROGRESS = entity.PROGRESS,
                                        	TASKREMARK = entity.TASKREMARK,
                                        	OWENRID = entity.OWENRID,
                                        	OWNERPOSTID = entity.OWNERPOSTID,
                                        	OWNERDEPARTMENTID = entity.OWNERDEPARTMENTID,
                                        	OWNERCOMPANYID = entity.OWNERCOMPANYID,
                                        	CREATETIME = entity.CREATETIME,
                                        	CREATEUSER = entity.CREATEUSER,
                                        	EDITTIME = entity.EDITTIME,
                                        	EDITUSER = entity.EDITUSER,
                                        	PMANAGER = entity.PMANAGER,
                                        	ISCOMFIRM = entity.ISCOMFIRM,
                                        	REALFINISHDATE = entity.REALFINISHDATE,
                                        	RESULTSCORE = entity.RESULTSCORE,
                                        	SUGGESTIONS = entity.SUGGESTIONS,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
