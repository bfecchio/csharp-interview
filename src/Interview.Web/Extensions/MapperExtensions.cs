using AutoMapper;
using System.Collections.Generic;

using Interview.Core.Domain;
using Interview.Web.Interfaces;

namespace Interview.Web.Extensions
{
    public static class MapperExtensions
    {
        #region Extension Methods - MapToViewModel (single)

        public static TViewModel MapToViewModel<TViewModel>(this IMapper mapper, IDomainEntity entity)
            where TViewModel : class, IViewModel
        {
            return (TViewModel)mapper.Map(entity, entity.GetType(), typeof(TViewModel));
        }

        public static TViewModel MapToViewModel<TViewModel, TEntity>(this IMapper mapper, TEntity entity)
            where TEntity : class, IDomainEntity
            where TViewModel : class, IViewModel
        {
            return mapper.Map<TEntity, TViewModel>(entity);
        }

        #endregion

        #region Extension Methods - MapToViewModel (collection)

        public static IEnumerable<TViewModel> MapToViewModel<TViewModel>(this IMapper mapper, IEnumerable<IDomainEntity> collection)
            where TViewModel : class, IViewModel
        {
            return (IEnumerable<TViewModel>)mapper.Map(collection, collection.GetType(), typeof(IEnumerable<TViewModel>));
        }

        public static IEnumerable<TViewModel> MapToViewModel<TViewModel, TEntity>(this IMapper mapper, IEnumerable<TEntity> collection)
            where TViewModel : class, IViewModel
            where TEntity : class, IDomainEntity
        {
            return mapper.Map<IEnumerable<TEntity>, IEnumerable<TViewModel>>(collection);
        }

        #endregion

        #region Extension Methods - MapToEntity (single)

        public static TEntity MapToEntity<TEntity>(this IMapper mapper, IViewModel viewModel)
            where TEntity : class, IDomainEntity
        {
            return (TEntity)mapper.Map(viewModel, viewModel.GetType(), typeof(TEntity));
        }

        public static TEntity MapToEntity<TEntity, TViewModel>(this IMapper mapper, TViewModel viewModel)
            where TEntity : class, IDomainEntity
            where TViewModel : class, IViewModel
        {
            return mapper.Map<TViewModel, TEntity>(viewModel);
        }

        #endregion

        #region Extension Methods - MapToEntity (collection)

        public static IEnumerable<TEntity> MapToEntity<TEntity>(this IMapper mapper, IEnumerable<IViewModel> collection)
            where TEntity : class, IDomainEntity
        {
            return (IEnumerable<TEntity>)mapper.Map(collection, collection.GetType(), typeof(IEnumerable<TEntity>));
        }

        public static IEnumerable<TEntity> MapToEntity<TEntity, TViewModel>(this IMapper mapper, IEnumerable<TViewModel> collection)
            where TEntity : class, IDomainEntity
            where TViewModel : class, IViewModel
        {
            return mapper.Map<IEnumerable<TViewModel>, IEnumerable<TEntity>>(collection);
        }

        #endregion
    }
}
