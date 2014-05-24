class PaquetesController < ApplicationController
  before_action :set_paquete, only: [:show, :edit, :update, :destroy]

  # GET /paquetes
  # GET /paquetes.json
  def index
    @paquetes = Paquete.all
  end

  # GET /paquetes/1
  # GET /paquetes/1.json
  def show
  end

  # GET /paquetes/new
  def new
    @paquete = Paquete.new
  end

  # GET /paquetes/1/edit
  def edit
  end

  # POST /paquetes
  # POST /paquetes.json
  def create
    @paquete = Paquete.new(paquete_params)

    respond_to do |format|
      if @paquete.save
        format.html { redirect_to @paquete, notice: 'Paquete was successfully created.' }
        format.json { render :show, status: :created, location: @paquete }
      else
        format.html { render :new }
        format.json { render json: @paquete.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /paquetes/1
  # PATCH/PUT /paquetes/1.json
  def update
    respond_to do |format|
      if @paquete.update(paquete_params)
        format.html { redirect_to @paquete, notice: 'Paquete was successfully updated.' }
        format.json { render :show, status: :ok, location: @paquete }
      else
        format.html { render :edit }
        format.json { render json: @paquete.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /paquetes/1
  # DELETE /paquetes/1.json
  def destroy
    @paquete.destroy
    respond_to do |format|
      format.html { redirect_to paquetes_url, notice: 'Paquete was successfully destroyed.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_paquete
      @paquete = Paquete.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def paquete_params
      params.require(:paquete).permit(:nombre, :valores_dez)
    end
end
