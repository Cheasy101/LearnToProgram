-adproject = learnToProgramm.Infrastructure.Persistence
solution = learnToProgramm

rm-db: stop-db
	@docker rm $(project)-db

stop-db:
	@docker stop $(project)-db

start-db:
	@docker start $(project)-db

create-db:
	@docker run -d \
	-p 54341:5432 \
	--name=$(project)-db \
	--restart=always \
	-e POSTGRES_DB=$(project) \
	-e POSTGRES_USER=$(project) \
	-e POSTGRES_PASSWORD=$(project) \
	postgres:alpine

migrate:
	@dotnet ef database update -v --no-color -s ./
	
migrate-add:
	@dotnet ef migrations add $(name) -v --no-color -s ./ -o ./Data/Migrations 
	
migrate-rm:
	@dotnet ef migrations remove -v --no-color -s ./
	
migrate-rollback:
	@dotnet ef database update $(name) -v --no-color -s ./ 