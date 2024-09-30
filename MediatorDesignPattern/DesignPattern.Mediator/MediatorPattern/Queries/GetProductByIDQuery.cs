using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductByIDQuery : IRequest<GetProductByIDQueryResult>
    {
        public GetProductByIDQuery(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; set; }
    }
}
