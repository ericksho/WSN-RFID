class AtributosController < ApplicationController
  before_action :set_atributo, only: [:show, :edit, :update, :destroy]

  # GET /atributos
  # GET /atributos.json
  def index
    @atributos = Atributo.all
  end

  # GET /atributos/1
  # GET /atributos/1.json
  def show
  end

  # GET /atributos/new
  def new
    @atributo = Atributo.new
    @label = "Crear"
  end

  # GET /atributos/1/edit
  def edit
    @label = "Actualizar"
  end

  # POST /atributos
  # POST /atributos.json
  def create
    @atributo = Atributo.new(atributo_params)

    respond_to do |format|
      if @atributo.save
        format.html { redirect_to atributos_path, notice: 'Atributo was successfully created.' }
        format.json { render :show, status: :created, location: @atributo }
      else
        format.html { render :new }
        format.json { render json: @atributo.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /atributos/1
  # PATCH/PUT /atributos/1.json
  def update
    respond_to do |format|
      if @atributo.update(atributo_params)
        format.html { redirect_to @atributo, notice: 'Atributo was successfully updated.' }
        format.json { render :show, status: :ok, location: @atributo }
      else
        format.html { render :edit }
        format.json { render json: @atributo.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /atributos/1
  # DELETE /atributos/1.json
  def destroy
    @atributo.destroy
    respond_to do |format|
      format.html { redirect_to atributos_url, notice: 'Atributo was successfully destroyed.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_atributo
      @atributo = Atributo.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def atributo_params
      params.require(:atributo).permit(:nombre_at, :valor, :tipo_variable)
    end
end
